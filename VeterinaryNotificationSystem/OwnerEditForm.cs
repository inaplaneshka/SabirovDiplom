using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class OwnerEditForm : Form
    {
        private int? ownerId;

        public OwnerEditForm(int? id = null)
        {
            ownerId = id;
            InitializeComponent();
            ConfigureForm();

            if (ownerId.HasValue)
            {
                Text = "Редактирование владельца";
                LoadOwnerData();
            }
            else
            {
                Text = "Добавление владельца";
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
            cmbOwnerType.Items.AddRange(new string[] { "Физическое лицо", "Юридическое лицо" });
            cmbOwnerType.SelectedIndex = 0;

            cmbSettlement.Items.AddRange(new string[] {
                "г. Острогожск", "с. Петровка", "д. Новоселовка", "с. Урыв", "х. Марьевка"
            });
        }

        private void LoadOwnerData()
        {
            // Загрузка данных владельца из базы
            // Временные данные
            txtLastName.Text = "Иванов";
            txtFirstName.Text = "Иван";
            txtMiddleName.Text = "Иванович";
            txtPhone.Text = "+7 (999) 123-45-67";
            txtEmail.Text = "ivanov@mail.ru";
            txtAddress.Text = "г. Острогожск, ул. Ленина, д. 1, кв. 5";
            cmbSettlement.SelectedItem = "г. Острогожск";
            txtINN.Text = "";
            cmbOwnerType.SelectedIndex = 0;
            txtNotes.Text = "Постоянный клиент";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            // Сохранение в базу данных
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введите фамилию", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Введите имя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Введите телефон", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Введите адрес", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}