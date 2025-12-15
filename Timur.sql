-- Создание базы данных
CREATE DATABASE VeterinaryNotificationDB;
GO

USE VeterinaryNotificationDB;
GO

-- Таблица сотрудников (администраторов системы)
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50),
    Position NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Phone NVARCHAR(20),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) DEFAULT 'Operator' CHECK (Role IN ('Admin', 'Operator', 'Viewer')),
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE()
);

-- Таблица типов животных
CREATE TABLE AnimalTypes (
    AnimalTypeID INT IDENTITY(1,1) PRIMARY KEY,
    TypeName NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(500)
);

-- Таблица видов животных (подвиды)
CREATE TABLE AnimalSpecies (
    SpeciesID INT IDENTITY(1,1) PRIMARY KEY,
    AnimalTypeID INT NOT NULL,
    SpeciesName NVARCHAR(100) NOT NULL,
    LatinName NVARCHAR(150),
    CONSTRAINT FK_AnimalSpecies_Types FOREIGN KEY (AnimalTypeID) 
        REFERENCES AnimalTypes(AnimalTypeID) ON DELETE CASCADE
);

-- Таблица владельцев животных
CREATE TABLE AnimalOwners (
    OwnerID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50),
    Phone NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100),
    Address NVARCHAR(500) NOT NULL,
    Settlement NVARCHAR(100), -- Населенный пункт
    District NVARCHAR(100) DEFAULT 'Острогожский',
    INN NVARCHAR(12), -- ИНН для юридических лиц
    OwnerType NVARCHAR(20) DEFAULT 'Physical' CHECK (OwnerType IN ('Physical', 'Legal')),
    RegistrationDate DATETIME DEFAULT GETDATE(),
    Notes NVARCHAR(1000)
);

-- Таблица животных
CREATE TABLE Animals (
    AnimalID INT IDENTITY(1,1) PRIMARY KEY,
    OwnerID INT NOT NULL,
    SpeciesID INT NOT NULL,
    Name NVARCHAR(100),
    Breed NVARCHAR(150),
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female', 'Unknown')),
    BirthDate DATE,
    Color NVARCHAR(100),
    DistinctiveFeatures NVARCHAR(500),
    MicrochipNumber NVARCHAR(50),
    RegistrationNumber NVARCHAR(50) UNIQUE,
    RegistrationDate DATETIME DEFAULT GETDATE(),
    LastExaminationDate DATE,
    NextExaminationDate DATE,
    IsActive BIT DEFAULT 1,
    CONSTRAINT FK_Animals_Owners FOREIGN KEY (OwnerID) 
        REFERENCES AnimalOwners(OwnerID) ON DELETE CASCADE,
    CONSTRAINT FK_Animals_Species FOREIGN KEY (SpeciesID) 
        REFERENCES AnimalSpecies(SpeciesID)
);

-- Таблица типов уведомлений
CREATE TABLE NotificationTypes (
    TypeID INT IDENTITY(1,1) PRIMARY KEY,
    TypeName NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(500),
    TemplateText NVARCHAR(2000),
    DefaultChannel NVARCHAR(20) DEFAULT 'SMS' CHECK (DefaultChannel IN ('SMS', 'Email', 'Both')),
    IsActive BIT DEFAULT 1
);

-- Таблица шаблонов уведомлений
CREATE TABLE NotificationTemplates (
    TemplateID INT IDENTITY(1,1) PRIMARY KEY,
    TypeID INT NOT NULL,
    Title NVARCHAR(200) NOT NULL,
    TemplateText NVARCHAR(2000) NOT NULL,
    Variables NVARCHAR(500), -- Список переменных, например: {OwnerName}, {AnimalName}, {Date}
    CreatedBy INT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    ModifiedDate DATETIME,
    IsActive BIT DEFAULT 1,
    CONSTRAINT FK_Templates_Types FOREIGN KEY (TypeID) 
        REFERENCES NotificationTypes(TypeID),
    CONSTRAINT FK_Templates_Employees FOREIGN KEY (CreatedBy) 
        REFERENCES Employees(EmployeeID)
);

-- Основная таблица уведомлений
CREATE TABLE Notifications (
    NotificationID INT IDENTITY(1,1) PRIMARY KEY,
    TemplateID INT NOT NULL,
    OwnerID INT NOT NULL,
    AnimalID INT,
    Title NVARCHAR(200) NOT NULL,
    MessageText NVARCHAR(2000) NOT NULL,
    Channel NVARCHAR(20) NOT NULL CHECK (Channel IN ('SMS', 'Email', 'Both')),
    ScheduledDate DATETIME,
    SentDate DATETIME,
    Status NVARCHAR(20) DEFAULT 'Draft' 
        CHECK (Status IN ('Draft', 'Scheduled', 'Sending', 'Sent', 'Failed', 'Cancelled')),
    DeliveryStatus NVARCHAR(500), -- Детальный статус доставки
    CreatedBy INT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Notifications_Templates FOREIGN KEY (TemplateID) 
        REFERENCES NotificationTemplates(TemplateID),
    CONSTRAINT FK_Notifications_Owners FOREIGN KEY (OwnerID) 
        REFERENCES AnimalOwners(OwnerID),
    CONSTRAINT FK_Notifications_Animals FOREIGN KEY (AnimalID) 
        REFERENCES Animals(AnimalID),
    CONSTRAINT FK_Notifications_Creator FOREIGN KEY (CreatedBy) 
        REFERENCES Employees(EmployeeID)
);

-- Таблица истории отправки
CREATE TABLE NotificationHistory (
    HistoryID INT IDENTITY(1,1) PRIMARY KEY,
    NotificationID INT NOT NULL,
    Channel NVARCHAR(20) NOT NULL,
    Recipient NVARCHAR(255) NOT NULL, -- Номер телефона или email
    AttemptDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(50) NOT NULL,
    ErrorMessage NVARCHAR(1000),
    CONSTRAINT FK_History_Notifications FOREIGN KEY (NotificationID) 
        REFERENCES Notifications(NotificationID) ON DELETE CASCADE
);

-- Таблица ветеринарных мероприятий
CREATE TABLE VeterinaryEvents (
    EventID INT IDENTITY(1,1) PRIMARY KEY,
    EventType NVARCHAR(100) NOT NULL, -- Вакцинация, осмотр, обработка и т.д.
    EventName NVARCHAR(200) NOT NULL,
    Description NVARCHAR(1000),
    StartDate DATE NOT NULL,
    EndDate DATE,
    Location NVARCHAR(300),
    ResponsibleEmployeeID INT,
    IsNotificationRequired BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Events_Employees FOREIGN KEY (ResponsibleEmployeeID) 
        REFERENCES Employees(EmployeeID)
);

-- Таблица привязки животных к мероприятиям
CREATE TABLE AnimalEventRegistrations (
    RegistrationID INT IDENTITY(1,1) PRIMARY KEY,
    EventID INT NOT NULL,
    AnimalID INT NOT NULL,
    RegistrationDate DATETIME DEFAULT GETDATE(),
    NotificationSent BIT DEFAULT 0,
    CONSTRAINT FK_Registrations_Events FOREIGN KEY (EventID) 
        REFERENCES VeterinaryEvents(EventID) ON DELETE CASCADE,
    CONSTRAINT FK_Registrations_Animals FOREIGN KEY (AnimalID) 
        REFERENCES Animals(AnimalID)
);

-- Таблица настроек системы
CREATE TABLE SystemSettings (
    SettingID INT IDENTITY(1,1) PRIMARY KEY,
    SettingKey NVARCHAR(100) UNIQUE NOT NULL,
    SettingValue NVARCHAR(MAX),
    Description NVARCHAR(500),
    Category NVARCHAR(100)
);

-- Таблица логов системы
CREATE TABLE SystemLogs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    LogDate DATETIME DEFAULT GETDATE(),
    LogLevel NVARCHAR(20) NOT NULL,
    Source NVARCHAR(200) NOT NULL,
    Message NVARCHAR(2000) NOT NULL,
    EmployeeID INT NULL,
    Details NVARCHAR(MAX),
    CONSTRAINT FK_Logs_Employees FOREIGN KEY (EmployeeID) 
        REFERENCES Employees(EmployeeID)
);


-- Создание индексов для улучшения производительности
CREATE INDEX IX_AnimalOwners_Phone ON AnimalOwners(Phone);
CREATE INDEX IX_AnimalOwners_Email ON AnimalOwners(Email);
CREATE INDEX IX_AnimalOwners_Settlement ON AnimalOwners(Settlement);
CREATE INDEX IX_Animals_OwnerID ON Animals(OwnerID);
CREATE INDEX IX_Animals_NextExaminationDate ON Animals(NextExaminationDate);
CREATE INDEX IX_Animals_RegistrationNumber ON Animals(RegistrationNumber);
CREATE INDEX IX_Notifications_Status ON Notifications(Status);
CREATE INDEX IX_Notifications_SentDate ON Notifications(SentDate);
CREATE INDEX IX_Notifications_OwnerID ON Notifications(OwnerID);
CREATE INDEX IX_NotificationHistory_NotificationID ON NotificationHistory(NotificationID);
CREATE INDEX IX_NotificationHistory_AttemptDate ON NotificationHistory(AttemptDate);
CREATE INDEX IX_VeterinaryEvents_StartDate ON VeterinaryEvents(StartDate);
CREATE INDEX IX_SystemLogs_LogDate ON SystemLogs(LogDate);

-- Добавление типов животных
INSERT INTO AnimalTypes (TypeName, Description) VALUES
(N'Собаки', N'Домашние собаки всех пород'),
(N'Кошки', N'Домашние кошки всех пород'),
(N'Крупный рогатый скот', N'Коровы, быки, телята'),
(N'Мелкий рогатый скот', N'Овцы, козы'),
(N'Лошади', N'Лошади, пони'),
(N'Птица', N'Куры, утки, гуси, индейки'),
(N'Кролики', N'Домашние и промысловые кролики');

-- Добавление видов животных
INSERT INTO AnimalSpecies (AnimalTypeID, SpeciesName, LatinName) VALUES
(1, N'Собака домашняя', 'Canis lupus familiaris'),
(2, N'Кошка домашняя', 'Felis catus'),
(3, N'Корова', 'Bos taurus'),
(3, N'Бык', 'Bos taurus'),
(4, N'Овца', 'Ovis aries'),
(4, N'Коза', 'Capra hircus'),
(5, N'Лошадь', 'Equus ferus caballus'),
(6, N'Курица', 'Gallus gallus domesticus'),
(6, N'Утка', 'Anas platyrhynchos domesticus'),
(7, N'Кролик домашний', 'Oryctolagus cuniculus domesticus');

-- Добавление типов уведомлений
INSERT INTO NotificationTypes (TypeName, Description, TemplateText, DefaultChannel) VALUES
(N'Вакцинация', N'Уведомление о необходимости вакцинации', 
N'Уважаемый {OwnerName}! Напоминаем о необходимости вакцинации Вашего животного {AnimalName} до {Date}. БУВО "Острогожская районная станция по борьбе с болезнями животных"', 
'SMS'),
(N'Осмотр', N'Уведомление о плановом осмотре',
N'Уважаемый {OwnerName}! Приглашаем на плановый осмотр животного {AnimalName} {Date}. Адрес: {Address}. БУВО "Острогожская районная станция"',
'Both'),
(N'Карантин', N'Уведомление о карантинных мероприятиях',
N'Внимание! В районе объявлен карантин по {Disease}. Просим соблюдать меры предосторожности. БУВО "Острогожская РСББЖ"',
'SMS'),
(N'Мероприятие', N'Уведомление о ветеринарных мероприятиях',
N'Уважаемые владельцы животных! {EventName} состоится {Date} по адресу: {Address}. БУВО "Острогожская районная станция"',
'Both'),
(N'Регистрация', N'Подтверждение регистрации животного',
N'Уважаемый {OwnerName}! Ваше животное {AnimalName} успешно зарегистрировано. Рег. номер: {RegNumber}. БУВО "Острогожская РСББЖ"',
'Email');

-- Добавление администратора по умолчанию 
INSERT INTO Employees (FirstName, LastName, Position, Email, Phone, Username, PasswordHash, Role) VALUES
(N'Иван', N'Иванов', N'Главный ветеринарный врач', 'admin@ostrogvet.ru', '+79001234567', 'admin', 
'12345', 'Admin'); 

-- Добавление настроек системы
INSERT INTO SystemSettings (SettingKey, SettingValue, Description, Category) VALUES
('SMS_Provider', 'SMSC', 'Провайдер SMS рассылки', 'Notification'),
('Email_Sender', 'notifications@ostrogvet.ru', 'Email отправителя', 'Notification'),
('SMS_SenderName', 'OstrogVet', 'Имя отправителя SMS', 'Notification'),
('WorkingHours', '8:00-17:00', 'Рабочие время для отправки уведомлений', 'General'),
('DefaultSettlement', 'Острогожск', 'Населенный пункт по умолчанию', 'General'),
('ExaminationPeriodDays', '365', 'Период между плановыми осмотрами (дни)', 'Veterinary');

