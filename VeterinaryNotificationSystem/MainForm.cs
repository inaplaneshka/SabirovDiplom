using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        private Employee currentEmployee;

        public MainForm()
        {
            InitializeComponent();
            ConfigureForm();
            CheckLogin();
        }

        private void CheckLogin()
        {
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                currentEmployee = loginForm.LoggedInEmployee;
                lblCurrentUser.Text = $"Пользователь: {currentEmployee.FullName} ({currentEmployee.Role})";
                EnableMenuItems();
            }
            else
            {
                Close();
            }
        }

        private void ConfigureForm()
        {
            // Настройка цветов формы
            this.BackColor = AppColors.BackgroundLight;

            // Настройка панелей
            panelLogo.BackColor = AppColors.PrimaryDark;
            panelTitle.BackColor = AppColors.PrimaryColor;
            panelMenu.BackColor = Color.FromArgb(240, 240, 240);
            panelDesktop.BackColor = AppColors.BackgroundLight;

            // Настройка лейблов
            lblTitle.ForeColor = AppColors.TextLight;
            lblSubtitle.ForeColor = AppColors.TextLight;
            lblCurrentUser.ForeColor = AppColors.TextLight;
        }

        private void EnableMenuItems()
        {
            // Включаем кнопки в зависимости от роли
            bool isAdmin = currentEmployee.Role == "Admin";
            bool isOperator = currentEmployee.Role == "Operator" || isAdmin;

            btnOwners.Enabled = isOperator;
            btnAnimals.Enabled = isOperator;
            btnNotifications.Enabled = isOperator;
            btnEvents.Enabled = isOperator;
            btnReports.Enabled = isOperator;
            btnUsers.Enabled = isAdmin;
            btnSettings.Enabled = isAdmin;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = AppColors.PrimaryLight;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(240, 240, 240);
                    previousBtn.ForeColor = AppColors.TextPrimary;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnOwners_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OwnersForm(), sender);
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AnimalsForm(), sender);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NotificationsForm(), sender);
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EventsForm(), sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsForm(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UsersForm(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsForm(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход из системы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentEmployee = null;
                lblCurrentUser.Text = "Пользователь: Не авторизован";
                CheckLogin();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Закрытие приложения",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FullName => $"{LastName} {FirstName} {MiddleName}";
        public string Position { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
    }
}