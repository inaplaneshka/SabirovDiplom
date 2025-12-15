using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class SelectOwnerForm : Form
    {
        public string SelectedOwnerName { get; private set; }
        public int SelectedOwnerId { get; private set; }

        public SelectOwnerForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadOwners();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;
            ConfigureDataGridView(dataOwners);

            btnSelect.BackColor = AppColors.PrimaryColor;
            btnSelect.ForeColor = Color.White;
            btnCancel.BackColor = AppColors.SecondaryColor;
            btnCancel.ForeColor = Color.White;
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = AppColors.PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void LoadOwners()
        {
            dataOwners.Rows.Clear();
            dataOwners.Rows.Add(1, "Иванов Иван Иванович", "+7 (999) 123-45-67", "г. Острогожск");
            dataOwners.Rows.Add(2, "Петров Петр Петрович", "+7 (999) 234-56-78", "с. Петровка");
            dataOwners.Rows.Add(3, "Сидоров Сидор Сидорович", "+7 (999) 345-67-89", "д. Новоселовка");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataOwners.SelectedRows.Count > 0)
            {
                SelectedOwnerId = Convert.ToInt32(dataOwners.SelectedRows[0].Cells["colSelectOwnerId"].Value);
                SelectedOwnerName = dataOwners.SelectedRows[0].Cells["colSelectOwnerName"].Value.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите владельца", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtSearchOwner_TextChanged(object sender, EventArgs e)
        {
            // Фильтрация списка
        }
    }
}