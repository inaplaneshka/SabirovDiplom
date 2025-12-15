using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class EventEditForm : Form
    {
        private int? eventId;

        public EventEditForm(int? id = null)
        {
            eventId = id;
            InitializeComponent();
            ConfigureForm();

            if (eventId.HasValue)
            {
                Text = "Редактирование мероприятия";
                LoadEventData();
            }
            else
            {
                Text = "Добавление мероприятия";
            }
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;

            // Кнопки
            btnSave.BackColor = AppColors.PrimaryColor;
            btnSave.ForeColor = Color.White;
            btnCancel.BackColor = AppColors.SecondaryColor;
            btnCancel.ForeColor = Color.White;

            // Заполнение выпадающих списков
            cmbEventType.Items.AddRange(new string[] {
                "Вакцинация", "Осмотр", "Обработка", "Карантин",
                "Обучение", "Собрание", "Другое"
            });
            cmbEventType.SelectedIndex = 0;

            // Даты по умолчанию
            dtpStartDate.Value = DateTime.Now.AddDays(7);
            dtpStartTime.Value = DateTime.Now.Date.AddHours(10);
            dtpEndDate.Value = DateTime.Now.AddDays(7);
            dtpEndTime.Value = DateTime.Now.Date.AddHours(13);

            chkNotificationRequired.Checked = true;
        }

        private void LoadEventData()
        {
            txtEventName.Text = "Массовая вакцинация собак";
            cmbEventType.SelectedItem = "Вакцинация";
            txtDescription.Text = "Ежегодная массовая вакцинация домашних собак от бешенства и других заболеваний";
            dtpStartDate.Value = new DateTime(2024, 12, 15);
            dtpStartTime.Value = new DateTime(2024, 12, 15, 9, 0, 0);
            dtpEndDate.Value = new DateTime(2024, 12, 17);
            dtpEndTime.Value = new DateTime(2024, 12, 17, 18, 0, 0);
            txtLocation.Text = "г. Острогожск, ул. Ветеринарная, 5";
            txtResponsible.Text = "Иванов Иван Иванович";
            chkNotificationRequired.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtEventName.Text))
            {
                MessageBox.Show("Введите название мероприятия", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEventName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Введите место проведения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return false;
            }

            DateTime startDateTime = dtpStartDate.Value.Date + dtpStartTime.Value.TimeOfDay;
            DateTime endDateTime = dtpEndDate.Value.Date + dtpEndTime.Value.TimeOfDay;

            if (startDateTime >= endDateTime)
            {
                MessageBox.Show("Дата окончания должна быть позже даты начала", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelectResponsible_Click(object sender, EventArgs e)
        {
            var selectForm = new SelectEmployeeForm();
            if (selectForm.ShowDialog() == DialogResult.OK)
            {
                txtResponsible.Text = selectForm.SelectedEmployeeName;
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            // Если дата окончания раньше даты начала, корректируем её
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                dtpEndDate.Value = dtpStartDate.Value;
            }
        }
    }
}