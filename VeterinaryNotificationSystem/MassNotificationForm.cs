using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class MassNotificationForm : Form
    {
        public MassNotificationForm()
        {
            InitializeComponent();
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;

            // Кнопки
            btnSend.BackColor = AppColors.PrimaryColor;
            btnSend.ForeColor = Color.White;
            btnCancel.BackColor = AppColors.SecondaryColor;
            btnCancel.ForeColor = Color.White;
            btnSelectAll.BackColor = AppColors.InfoColor;
            btnSelectAll.ForeColor = Color.White;
            btnDeselectAll.BackColor = AppColors.WarningColor;
            btnDeselectAll.ForeColor = Color.White;
            btnTest.BackColor = AppColors.SecondaryLight;
            btnTest.ForeColor = Color.White;

            // Заполнение выпадающих списков
            cmbChannel.Items.AddRange(new string[] { "SMS", "Email", "SMS и Email" });
            cmbChannel.SelectedIndex = 0;

            cmbTemplate.Items.AddRange(new string[] {
                "Вакцинация - массовая",
                "Осмотр - плановый массовый",
                "Карантин - общее уведомление",
                "Мероприятие - приглашение"
            });
            cmbTemplate.SelectedIndex = 0;

            // Дата и время
            dtpScheduledDate.Value = DateTime.Now.AddDays(1);
            dtpScheduledTime.Value = DateTime.Now.Date.AddHours(10);

            // Загрузка владельцев
            LoadOwners();
        }

        private void LoadOwners()
        {
            dataOwners.Rows.Clear();

            // Пример данных
            dataOwners.Rows.Add(true, 1, "Иванов Иван Иванович", "+7 (999) 123-45-67", "г. Острогожск", "Собака, Кошка");
            dataOwners.Rows.Add(true, 2, "Петров Петр Петрович", "+7 (999) 234-56-78", "с. Петровка", "Корова");
            dataOwners.Rows.Add(true, 3, "Сидоров Сидор Сидорович", "+7 (999) 345-67-89", "д. Новоселовка", "Куры");
            dataOwners.Rows.Add(false, 4, "Кузнецова Мария Ивановна", "+7 (999) 456-78-90", "г. Острогожск", "Кошка");
            dataOwners.Rows.Add(true, 5, "ООО 'Агроферма'", "+7 (999) 567-89-01", "х. Марьевка", "КРС, МРС");

            UpdateSelectionCount();
        }

        private void UpdateSelectionCount()
        {
            int selected = 0;
            foreach (DataGridViewRow row in dataOwners.Rows)
            {
                if (row.Cells["colSelected"].Value != null && (bool)row.Cells["colSelected"].Value)
                    selected++;
            }

            lblSelectionCount.Text = $"Выбрано: {selected} из {dataOwners.Rows.Count}";
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataOwners.Rows)
            {
                row.Cells["colSelected"].Value = true;
            }
            UpdateSelectionCount();
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataOwners.Rows)
            {
                row.Cells["colSelected"].Value = false;
            }
            UpdateSelectionCount();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            int selectedCount = GetSelectedCount();
            if (selectedCount == 0)
            {
                MessageBox.Show("Выберите хотя бы одного получателя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime scheduledDateTime = dtpScheduledDate.Value.Date + dtpScheduledTime.Value.TimeOfDay;
            string confirmationMessage = $"Отправить массовое уведомление {selectedCount} получателям?\n" +
                                       $"Канал: {cmbChannel.Text}\n" +
                                       $"Запланировано на: {scheduledDateTime:dd.MM.yyyy HH:mm}";

            if (MessageBox.Show(confirmationMessage, "Подтверждение массовой рассылки",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show($"Массовое уведомление отправлено {selectedCount} получателям", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private int GetSelectedCount()
        {
            int count = 0;
            foreach (DataGridViewRow row in dataOwners.Rows)
            {
                if (row.Cells["colSelected"].Value != null && (bool)row.Cells["colSelected"].Value)
                    count++;
            }
            return count;
        }

        private bool ValidateForm()
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

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MessageBox.Show("Тестовое уведомление отправлено администратору", "Тест отправки",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Загрузка шаблона
            switch (cmbTemplate.SelectedIndex)
            {
                case 0: // Вакцинация массовая
                    txtTitle.Text = "Массовая вакцинация животных";
                    txtMessage.Text = "Уважаемые владельцы животных! Приглашаем на массовую вакцинацию животных с {Дата начала} по {Дата окончания}. Место проведения: {Адрес станции}. БУВО \"Острогожская районная станция\"";
                    break;
                case 1: // Осмотр массовый
                    txtTitle.Text = "Плановый массовый осмотр";
                    txtMessage.Text = "Уведомляем о проведении планового массового осмотра животных {Дата}. Просим обеспечить доступ к животным. БУВО \"Острогожская районная станция\"";
                    break;
                case 2: // Карантин
                    txtTitle.Text = "ВАЖНО: Карантинные мероприятия";
                    txtMessage.Text = "Внимание! В связи с выявлением {Заболевание} в районе объявляются карантинные мероприятия. Просим соблюдать все предписания. БУВО \"Острогожская РСББЖ\"";
                    break;
            }
        }

        private void dataOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataOwners.Columns["colSelected"].Index && e.RowIndex >= 0)
            {
                UpdateSelectionCount();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Фильтрация списка владельцев
            string searchText = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dataOwners.Rows)
            {
                bool visible = string.IsNullOrEmpty(searchText) ||
                    row.Cells["colOwnerName"].Value.ToString().ToLower().Contains(searchText) ||
                    row.Cells["colOwnerPhone"].Value.ToString().ToLower().Contains(searchText) ||
                    row.Cells["colOwnerAddress"].Value.ToString().ToLower().Contains(searchText);

                row.Visible = visible;
            }
        }
    }
}