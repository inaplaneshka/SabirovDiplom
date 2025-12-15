using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class UserEditForm : Form
    {
        private int? userId;

        public UserEditForm(int? id = null)
        {
            userId = id;
            InitializeComponent();
            ConfigureForm();

            if (userId.HasValue)
            {
                Text = "Редактирование пользователя";
                LoadUserData();
            }
            else
            {
                Text = "Добавление пользователя";
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
            cmbRole.Items.AddRange(new string[] { "Admin", "Operator", "Viewer" });
            cmbRole.SelectedIndex = 1;

            chkIsActive.Checked = true;
        }

        private void LoadUserData()
        {
            // Пример данных пользователя
            txtFirstName.Text = "Иван";
            txtLastName.Text = "Иванов";
            txtMiddleName.Text = "Иванович";
            txtPosition.Text = "Главный ветеринарный врач";
            txtEmail.Text = "ivanov@ostrogvet.ru";
            txtPhone.Text = "+7 (999) 123-45-67";
            txtUsername.Text = "admin";
            cmbRole.SelectedItem = "Admin";
            chkIsActive.Checked = true;
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
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Введите имя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введите фамилию", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Введите логин", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text) && !userId.HasValue)
            {
                MessageBox.Show("Введите пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = chkChangePassword.Checked || !userId.HasValue;
            txtPassword.Enabled = enabled;
            txtConfirmPassword.Enabled = enabled;
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}