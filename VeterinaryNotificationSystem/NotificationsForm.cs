using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class NotificationsForm : Form
    {
        public NotificationsForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadNotifications();
            LoadTemplates();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;

            // Панели
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.SelectedIndex = 0;

            // Конфигурация DataGridView для списка уведомлений
            ConfigureDataGridView(dataNotifications);

            // Конфигурация DataGridView для шаблонов
            ConfigureDataGridView(dataTemplates);

            // Цвета кнопок
            ConfigureButton(btnCreate, AppColors.PrimaryColor);
            ConfigureButton(btnSendNow, AppColors.SuccessColor);
            ConfigureButton(btnSchedule, AppColors.InfoColor);
            ConfigureButton(btnCancelNotification, AppColors.DangerColor);
            ConfigureButton(btnPreview, AppColors.SecondaryColor);
            ConfigureButton(btnAddTemplate, AppColors.PrimaryColor);
            ConfigureButton(btnEditTemplate, AppColors.SecondaryColor);
            ConfigureButton(btnDeleteTemplate, AppColors.DangerColor);
            ConfigureButton(btnMassNotification, AppColors.WarningColor);

            // Заполнение выпадающих списков
            cmbChannel.Items.AddRange(new string[] { "SMS", "Email", "SMS и Email" });
            cmbChannel.SelectedIndex = 0;

            cmbStatus.Items.AddRange(new string[] { "Все", "Черновик", "Запланировано", "Отправляется", "Отправлено", "Ошибка", "Отменено" });
            cmbStatus.SelectedIndex = 0;

            cmbTemplateType.Items.AddRange(new string[] { "Все", "Вакцинация", "Осмотр", "Карантин", "Мероприятие", "Регистрация" });
            cmbTemplateType.SelectedIndex = 0;

            // Дата и время по умолчанию
            dtpScheduledDate.Value = DateTime.Now.AddDays(1);
            dtpScheduledDate.MinDate = DateTime.Now;
            dtpScheduledTime.Value = DateTime.Now.Date.AddHours(10);

            // Настройка текстовых полей
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtTemplateText.ScrollBars = ScrollBars.Vertical;
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = AppColors.PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            dgv.RowHeadersDefaultCellStyle.BackColor = AppColors.PrimaryLight;
            dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigureButton(Button button, Color color)
        {
            button.BackColor = color;
            button.ForeColor = Color.White;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
        }

        private void LoadNotifications()
        {
            dataNotifications.Rows.Clear();

            // Пример данных
            dataNotifications.Rows.Add(
                1,
                "Напоминание о вакцинации",
                "Иванов И.И.",
                "Шарик (собака)",
                "SMS",
                "Запланировано",
                "15.12.2024 10:00",
                "14.12.2024",
                "Иванов А.А."
            );

            dataNotifications.Rows.Add(
                2,
                "Приглашение на осмотр",
                "Петров П.П.",
                "Мурка (кошка)",
                "Email",
                "Отправлено",
                "10.12.2024 14:30",
                "10.12.2024",
                "Петрова С.И."
            );

            dataNotifications.Rows.Add(
                3,
                "Объявление о карантине",
                "Все владельцы",
                "-",
                "SMS",
                "Отправлено",
                "05.12.2024 09:00",
                "05.12.2024",
                "Сидоров В.В."
            );

            UpdateStatusColors();
        }

        private void UpdateStatusColors()
        {
            foreach (DataGridViewRow row in dataNotifications.Rows)
            {
                if (row.Cells["colNotificationStatus"].Value != null)
                {
                    string status = row.Cells["colNotificationStatus"].Value.ToString();
                    Color statusColor = GetStatusColor(status);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(30, statusColor.R, statusColor.G, statusColor.B);
                }
            }
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Отправлено":
                    return AppColors.SuccessColor;
                case "Запланировано":
                    return AppColors.InfoColor;
                case "Отправляется":
                    return AppColors.WarningColor;
                case "Ошибка":
                    return AppColors.DangerColor;
                case "Отменено":
                    return Color.Gray;
                default:
                    return AppColors.PrimaryLight;
            }
        }

        private void LoadTemplates()
        {
            dataTemplates.Rows.Clear();
            cmbNotificationTemplate.Items.Clear();

            // Пример данных шаблонов
            string[] templates = {
                "Вакцинация - стандартное",
                "Вакцинация - срочное",
                "Осмотр - плановый",
                "Осмотр - внеплановый",
                "Карантин - общее",
                "Карантин - частное",
                "Мероприятие - приглашение",
                "Регистрация - подтверждение",
                "Регистрация - напоминание"
            };

            foreach (var template in templates)
            {
                cmbNotificationTemplate.Items.Add(template);
                dataTemplates.Rows.Add(template, "Вакцинация", "14.12.2024", "Активен");
            }

            if (cmbNotificationTemplate.Items.Count > 0)
                cmbNotificationTemplate.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageCreate;
            lblFormTitle.Text = "Создание уведомления";
            ClearCreateForm();
        }

        private void ClearCreateForm()
        {
            txtTitle.Text = "";
            txtMessage.Text = "";
            txtOwner.Text = "";
            txtAnimal.Text = "";
            cmbChannel.SelectedIndex = 0;
            dtpScheduledDate.Value = DateTime.Now.AddDays(1);
            dtpScheduledTime.Value = DateTime.Now.Date.AddHours(10);
            cmbNotificationTemplate.SelectedIndex = 0;
        }

        private void btnSendNow_Click(object sender, EventArgs e)
        {
            if (ValidateNotificationForm())
            {
                if (MessageBox.Show("Отправить уведомление сейчас?", "Подтверждение отправки",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Отправка уведомления
                    MessageBox.Show("Уведомление успешно отправлено", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Возвращаемся к списку
                    tabControl.SelectedTab = tabPageList;
                    LoadNotifications();
                }
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (ValidateNotificationForm())
            {
                DateTime scheduledDateTime = dtpScheduledDate.Value.Date + dtpScheduledTime.Value.TimeOfDay;

                if (MessageBox.Show($"Запланировать отправку на {scheduledDateTime:dd.MM.yyyy HH:mm}?",
                    "Подтверждение планирования", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Запланировать отправку
                    MessageBox.Show($"Уведомление запланировано на {scheduledDateTime:dd.MM.yyyy HH:mm}",
                        "Запланировано", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tabControl.SelectedTab = tabPageList;
                    LoadNotifications();
                }
            }
        }

        private bool ValidateNotificationForm()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите заголовок уведомления", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Введите текст сообщения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMessage.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOwner.Text))
            {
                MessageBox.Show("Выберите получателя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectOwner.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelNotification_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageList;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                string previewText = $"=== Предпросмотр ===\n\n" +
                                   $"Заголовок: {txtTitle.Text}\n" +
                                   $"Канал: {cmbChannel.Text}\n" +
                                   $"Получатель: {txtOwner.Text}\n" +
                                   $"Животное: {txtAnimal.Text}\n\n" +
                                   $"Сообщение:\n{txtMessage.Text}\n\n" +
                                   $"Длина SMS: {CalculateSMSCount(txtMessage.Text)} символов";

                MessageBox.Show(previewText, "Предпросмотр уведомления",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int CalculateSMSCount(string text)
        {
            // Обычно SMS ограничено 160 символами
            return text.Length;
        }

        private void cmbNotificationTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Загрузка шаблона
            switch (cmbNotificationTemplate.SelectedIndex)
            {
                case 0: // Вакцинация стандартное
                    txtTitle.Text = "Напоминание о вакцинации";
                    txtMessage.Text = "Уважаемый {ФИО владельца}! Напоминаем о необходимости вакцинации Вашего животного {Имя животного} до {Дата}. БУВО \"Острогожская районная станция по борьбе с болезнями животных\"";
                    break;
                case 1: // Вакцинация срочное
                    txtTitle.Text = "СРОЧНО: Вакцинация";
                    txtMessage.Text = "Уважаемый {ФИО владельца}! Требуется срочная вакцинация животного {Имя животного}. Свяжитесь с нами по телефону {Телефон станции}";
                    break;
                case 2: // Осмотр плановый
                    txtTitle.Text = "Приглашение на плановый осмотр";
                    txtMessage.Text = "Уважаемый {ФИО владельца}! Приглашаем на плановый осмотр животного {Имя животного} {Дата} в {Время}. Адрес: {Адрес станции}. БУВО \"Острогожская районная станция\"";
                    break;
            }
        }

        private void btnSelectOwner_Click(object sender, EventArgs e)
        {
            var selectForm = new SelectOwnerForm();
            if (selectForm.ShowDialog() == DialogResult.OK)
            {
                txtOwner.Text = selectForm.SelectedOwnerName;
            }
        }

        private void btnSelectAnimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOwner.Text))
            {
                var selectForm = new SelectAnimalForm();
                if (selectForm.ShowDialog() == DialogResult.OK)
                {
                    txtAnimal.Text = selectForm.SelectedAnimalName;
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите владельца", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMassNotification_Click(object sender, EventArgs e)
        {
            var massForm = new MassNotificationForm();
            if (massForm.ShowDialog() == DialogResult.OK)
            {
                LoadNotifications();
            }
        }

        private void btnSearchNotifications_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchNotifications.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                // Фильтрация уведомлений
                MessageBox.Show($"Поиск уведомлений: {searchText}", "Поиск",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Фильтрация по статусу
        }

        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageTemplates;
            ClearTemplateForm();
            lblTemplateFormTitle.Text = "Добавление шаблона";
        }

        private void ClearTemplateForm()
        {
            txtTemplateTitle.Text = "";
            txtTemplateText.Text = "";
            cmbTemplateTypeCreate.SelectedIndex = 0;
            txtTemplateVariables.Text = "{ФИО владельца}, {Имя животного}, {Дата}, {Время}, {Адрес станции}";
        }

        private void btnEditTemplate_Click(object sender, EventArgs e)
        {
            if (dataTemplates.SelectedRows.Count > 0)
            {
                tabControl.SelectedTab = tabPageTemplates;
                lblTemplateFormTitle.Text = "Редактирование шаблона";

                // Загрузка данных шаблона
                txtTemplateTitle.Text = dataTemplates.SelectedRows[0].Cells["colTemplateName"].Value.ToString();
                txtTemplateText.Text = "Пример текста шаблона...";
                cmbTemplateTypeCreate.SelectedIndex = 0;
            }
        }

        private void btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            if (dataTemplates.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Удалить выбранный шаблон?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LoadTemplates();
                }
            }
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            if (ValidateTemplateForm())
            {
                MessageBox.Show("Шаблон сохранен", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl.SelectedTab = tabPageList;
                LoadTemplates();
            }
        }

        private bool ValidateTemplateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTemplateTitle.Text))
            {
                MessageBox.Show("Введите название шаблона", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTemplateTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTemplateText.Text))
            {
                MessageBox.Show("Введите текст шаблона", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTemplateText.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelTemplate_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageList;
        }

        /*private void dataNotifications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Просмотр деталей уведомления
                var detailForm = new NotificationDetailForm(
                    dataNotifications.Rows[e.RowIndex].Cells["colNotificationId"].Value.ToString(),
                    dataNotifications.Rows[e.RowIndex].Cells["colNotificationTitle"].Value.ToString()
                );
                detailForm.ShowDialog();
            }
       */ 

        private void btnResend_Click(object sender, EventArgs e)
        {
            if (dataNotifications.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Повторно отправить выбранное уведомление?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Уведомление отправлено повторно", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelScheduled_Click(object sender, EventArgs e)
        {
            if (dataNotifications.SelectedRows.Count > 0)
            {
                string status = dataNotifications.SelectedRows[0].Cells["colNotificationStatus"].Value.ToString();
                if (status == "Запланировано")
                {
                    if (MessageBox.Show("Отменить запланированное уведомление?", "Подтверждение отмены",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        MessageBox.Show("Уведомление отменено", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNotifications();
                    }
                }
                else
                {
                    MessageBox.Show("Можно отменить только запланированные уведомления", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataTemplates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Использовать шаблон для создания уведомления
                tabControl.SelectedTab = tabPageCreate;
                cmbNotificationTemplate.SelectedItem = dataTemplates.Rows[e.RowIndex].Cells["colTemplateName"].Value.ToString();
            }
        }
    }
}