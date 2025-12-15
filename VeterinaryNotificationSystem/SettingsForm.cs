using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadSettings();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;

            btnSave.BackColor = AppColors.PrimaryColor;
            btnSave.ForeColor = Color.White;
            btnTestSMS.BackColor = AppColors.SecondaryColor;
            btnTestSMS.ForeColor = Color.White;
            btnTestEmail.BackColor = AppColors.InfoColor;
            btnTestEmail.ForeColor = Color.White;
        }

        private void LoadSettings()
        {
            // Пример настроек
            txtSMSProvider.Text = "SMSC";
            txtSMSSender.Text = "OstrogVet";
            txtEmailSender.Text = "notifications@ostrogvet.ru";
            txtEmailServer.Text = "smtp.gmail.com";
            numEmailPort.Value = 587;
            chkUseSSL.Checked = true;
            txtWorkingHours.Text = "8:00-17:00";
            numExaminationDays.Value = 365;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateSettings())
            {
                MessageBox.Show("Настройки сохранены", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateSettings()
        {
            if (string.IsNullOrWhiteSpace(txtSMSProvider.Text))
            {
                MessageBox.Show("Введите провайдера SMS", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSMSProvider.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmailSender.Text))
            {
                MessageBox.Show("Введите email отправителя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailSender.Focus();
                return false;
            }

            return true;
        }

        private void btnTestSMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тестовая SMS отправлена", "Тест SMS",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTestEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тестовый email отправлен", "Тест Email",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}