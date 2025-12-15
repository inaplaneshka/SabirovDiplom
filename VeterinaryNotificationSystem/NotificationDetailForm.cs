using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class NotificationDetailForm : Form
    {
        private NotificationModel _notification;

        public NotificationDetailForm(NotificationModel notification)
        {
            InitializeComponent();
            _notification = notification;
            ConfigureForm();
            LoadNotificationData();
        }

        public NotificationDetailForm(int notificationId)
        {
            InitializeComponent();
            LoadNotificationById(notificationId);
            ConfigureForm();
            LoadNotificationData();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;

            // Настройка цветов кнопок
            btnClose.BackColor = AppColors.SecondaryColor;
            btnClose.ForeColor = Color.White;

            btnResend.BackColor = AppColors.InfoColor;
            btnResend.ForeColor = Color.White;

            btnCancelNotification.BackColor = AppColors.WarningColor;
            btnCancelNotification.ForeColor = Color.White;

            btnMarkAsRead.BackColor = AppColors.SuccessColor;
            btnMarkAsRead.ForeColor = Color.White;

            // Настройка видимости кнопок в зависимости от статуса
            UpdateButtonVisibility();
        }

        private void LoadNotificationById(int notificationId)
        {
            // Загрузка уведомления из базы данных по ID
            // Временная заглушка - создаем тестовые данные
            _notification = new NotificationModel
            {
                Id = notificationId,
                Title = "Тестовое уведомление",
                Message = "Уважаемые владельцы животных! Приглашаем на массовую вакцинацию животных с 15.11.2023 по 30.11.2023.",
                Status = NotificationStatus.Sent,
                Channel = NotificationChannel.SMS,
                CreatedDate = DateTime.Now.AddDays(-2),
                ScheduledTime = DateTime.Now.AddDays(-1),
                SentTime = DateTime.Now.AddDays(-1),
                DeliveryStatus = DeliveryStatus.Delivered,
                RecipientName = "Иванов Иван Иванович",
                RecipientPhone = "+7 (999) 123-45-67",
                RecipientEmail = "ivanov@mail.ru",
                AnimalInfo = "Собака, Кошка"
            };
        }

        private void LoadNotificationData()
        {
            if (_notification == null)
            {
                MessageBox.Show("Уведомление не найдено", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Общая информация
            lblNotificationId.Text = _notification.Id.ToString();
            lblStatus.Text = GetStatusText(_notification.Status);
            lblStatus.ForeColor = GetStatusColor(_notification.Status);
            lblCreationDate.Text = _notification.CreatedDate.ToString("dd.MM.yyyy HH:mm");
            lblChannel.Text = GetChannelText(_notification.Channel);

            // Сообщение
            lblMessageTitle.Text = _notification.Title;
            txtMessageContent.Text = _notification.Message;

            // Получатель
            lblRecipientName.Text = _notification.RecipientName;
            lblRecipientPhone.Text = _notification.RecipientPhone;
            lblRecipientEmail.Text = _notification.RecipientEmail ?? "-";
            lblAnimalInfo.Text = _notification.AnimalInfo ?? "-";

            // Доставка
            lblScheduledTime.Text = _notification.ScheduledTime?.ToString("dd.MM.yyyy HH:mm") ?? "-";
            lblSentTime.Text = _notification.SentTime?.ToString("dd.MM.yyyy HH:mm") ?? "-";
            lblDeliveryStatus.Text = GetDeliveryStatusText(_notification.DeliveryStatus);
            lblDeliveryStatus.ForeColor = GetDeliveryStatusColor(_notification.DeliveryStatus);
            lblErrorInfo.Text = _notification.ErrorMessage ?? "-";
            lblErrorInfo.ForeColor = string.IsNullOrEmpty(_notification.ErrorMessage) ?
                Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33))))) :
                Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
        }

        private string GetStatusText(NotificationStatus status)
        {
            switch (status)
            {
                case NotificationStatus.Draft: return "Черновик";
                case NotificationStatus.Scheduled: return "Запланировано";
                case NotificationStatus.Sent: return "Отправлено";
                case NotificationStatus.Delivered: return "Доставлено";
                case NotificationStatus.Read: return "Прочитано";
                case NotificationStatus.Failed: return "Ошибка";
                case NotificationStatus.Cancelled: return "Отменено";
                default: return "Неизвестно";
            }
        }

        private Color GetStatusColor(NotificationStatus status)
        {
            switch (status)
            {
                case NotificationStatus.Draft: return Color.Gray;
                case NotificationStatus.Scheduled: return Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
                case NotificationStatus.Sent: return Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
                case NotificationStatus.Delivered: return Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
                case NotificationStatus.Read: return Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
                case NotificationStatus.Failed: return Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
                case NotificationStatus.Cancelled: return Color.DarkGray;
                default: return Color.Black;
            }
        }

        private string GetChannelText(NotificationChannel channel)
        {
            switch (channel)
            {
                case NotificationChannel.SMS: return "SMS";
                case NotificationChannel.Email: return "Email";
                case NotificationChannel.Both: return "SMS и Email";
                default: return "Неизвестно";
            }
        }

        private string GetDeliveryStatusText(DeliveryStatus status)
        {
            switch (status)
            {
                case DeliveryStatus.Pending: return "В ожидании";
                case DeliveryStatus.Sending: return "Отправляется";
                case DeliveryStatus.Sent: return "Отправлено";
                case DeliveryStatus.Delivered: return "Доставлено";
                case DeliveryStatus.Failed: return "Ошибка";
                case DeliveryStatus.Cancelled: return "Отменено";
                default: return "Неизвестно";
            }
        }

        private Color GetDeliveryStatusColor(DeliveryStatus status)
        {
            switch (status)
            {
                case DeliveryStatus.Pending: return Color.Gray;
                case DeliveryStatus.Sending: return Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
                case DeliveryStatus.Sent: return Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
                case DeliveryStatus.Delivered: return Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
                case DeliveryStatus.Failed: return Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
                case DeliveryStatus.Cancelled: return Color.DarkGray;
                default: return Color.Black;
            }
        }

        private void UpdateButtonVisibility()
        {
            if (_notification == null) return;

            // Кнопка "Прочитано" видна только для доставленных сообщений
            btnMarkAsRead.Visible = _notification.Status == NotificationStatus.Delivered;

            // Кнопка "Отменить" видна только для запланированных
            btnCancelNotification.Visible = _notification.Status == NotificationStatus.Scheduled;

            // Кнопка "Повторить" видна только для неудачных отправок
            btnResend.Visible = _notification.Status == NotificationStatus.Failed ||
                               _notification.DeliveryStatus == DeliveryStatus.Failed;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Повторно отправить это уведомление?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Логика повторной отправки
                // TODO: Реализовать повторную отправку уведомления

                _notification.Status = NotificationStatus.Scheduled;
                _notification.ScheduledTime = DateTime.Now.AddMinutes(5);
                _notification.DeliveryStatus = DeliveryStatus.Pending;

                // Обновляем интерфейс
                LoadNotificationData();
                UpdateButtonVisibility();

                MessageBox.Show("Уведомление запланировано для повторной отправки", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelNotification_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Отменить это уведомление?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Логика отмены уведомления
                // TODO: Реализовать отмену уведомления

                _notification.Status = NotificationStatus.Cancelled;
                _notification.DeliveryStatus = DeliveryStatus.Cancelled;

                // Обновляем интерфейс
                LoadNotificationData();
                UpdateButtonVisibility();

                MessageBox.Show("Уведомление отменено", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Отметить уведомление как прочитанное?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Логика отметки как прочитанного
                // TODO: Реализовать отметку как прочитанного

                _notification.Status = NotificationStatus.Read;

                // Обновляем интерфейс
                LoadNotificationData();
                UpdateButtonVisibility();

                MessageBox.Show("Уведомление отмечено как прочитанное", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    // Модели данных
    public enum NotificationStatus
    {
        Draft,
        Scheduled,
        Sent,
        Delivered,
        Read,
        Failed,
        Cancelled
    }

    public enum NotificationChannel
    {
        SMS,
        Email,
        Both
    }

    public enum DeliveryStatus
    {
        Pending,
        Sending,
        Sent,
        Delivered,
        Failed,
        Cancelled
    }

    public class NotificationModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public NotificationStatus Status { get; set; }
        public NotificationChannel Channel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ScheduledTime { get; set; }
        public DateTime? SentTime { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public string ErrorMessage { get; set; }
        public string RecipientName { get; set; }
        public string RecipientPhone { get; set; }
        public string RecipientEmail { get; set; }
        public string AnimalInfo { get; set; }
    }
}