using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VeterinaryNotificationSystem
{
    public partial class AnimalEditForm : Form
    {
        private int? animalId;

        public AnimalEditForm(int? id = null)
        {
            animalId = id;
            InitializeComponent();
            ConfigureForm();

            if (animalId.HasValue)
            {
                Text = "Редактирование животного";
                LoadAnimalData();
            }
            else
            {
                Text = "Добавление животного";
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
            cmbGender.Items.AddRange(new string[] { "Самец", "Самка", "Неизвестно" });
            cmbGender.SelectedIndex = 2;

            // Пример видов животных
            cmbSpecies.Items.AddRange(new string[] {
                "Собака домашняя",
                "Кошка домашняя",
                "Корова",
                "Овца",
                "Лошадь",
                "Курица"
            });
            if (cmbSpecies.Items.Count > 0) cmbSpecies.SelectedIndex = 0;

            // Дата рождения по умолчанию - сегодня минус 1 год
            dtpBirthDate.Value = DateTime.Now.AddYears(-1);
            dtpLastExamination.Value = DateTime.Now.AddMonths(-6);
            dtpNextExamination.Value = DateTime.Now.AddMonths(6);
        }

        private void LoadAnimalData()
        {
            // Пример данных
            txtName.Text = "Шарик";
            cmbSpecies.SelectedItem = "Собака домашняя";
            txtBreed.Text = "Овчарка";
            txtOwner.Text = "Иванов Иван Иванович";
            cmbGender.SelectedIndex = 0;
            dtpBirthDate.Value = new DateTime(2020, 1, 1);
            txtColor.Text = "Черно-рыжий";
            txtFeatures.Text = "Белое пятно на груди";
            txtMicrochip.Text = "123456789012345";
            txtRegNumber.Text = "ОСТ-2020-001";
            dtpLastExamination.Value = new DateTime(2024, 1, 1);
            dtpNextExamination.Value = new DateTime(2025, 1, 1);
            chkActive.Checked = true;
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
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите кличку животного", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOwner.Text))
            {
                MessageBox.Show("Выберите владельца", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectOwner.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelectOwner_Click(object sender, EventArgs e)
        {
            var selectForm = new SelectOwnerForm();
            if (selectForm.ShowDialog() == DialogResult.OK)
            {
                txtOwner.Text = selectForm.SelectedOwnerName;
            }
        }

        private void chkBirthDateUnknown_CheckedChanged(object sender, EventArgs e)
        {
            dtpBirthDate.Enabled = !chkBirthDateUnknown.Checked;
        }
    }
}