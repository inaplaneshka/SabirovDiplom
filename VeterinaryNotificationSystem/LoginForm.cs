using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class LoginForm : Form
    {
        public Employee LoggedInEmployee { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;

            panelHeader.BackColor = AppColors.PrimaryColor;
            lblTitle.ForeColor = AppColors.TextLight;
            lblSubtitle.ForeColor = AppColors.TextLight;

            btnLogin.BackColor = AppColors.PrimaryColor;
            btnLogin.ForeColor = AppColors.TextLight;

            btnCancel.BackColor = AppColors.SecondaryColor;
            btnCancel.ForeColor = AppColors.TextLight;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите имя пользователя и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Здесь должна быть проверка в базе данных
            // Временный код для демонстрации
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
            {
                LoggedInEmployee = new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Иван",
                    LastName = "Иванов",
                    MiddleName = "Иванович",
                    Position = "Главный ветеринарный врач",
                    Username = "admin",
                    Role = "Admin"
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка авторизации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}