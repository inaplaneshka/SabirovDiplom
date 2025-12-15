using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class SelectAnimalForm : Form
    {
        public string SelectedAnimalName { get; private set; }
        public int SelectedAnimalId { get; private set; }

        public SelectAnimalForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadAnimals();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;
            ConfigureDataGridView(dataAnimals);

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

        private void LoadAnimals()
        {
            dataAnimals.Rows.Clear();
            dataAnimals.Rows.Add(1, "Шарик", "Собака", "Овчарка", "Иванов И.И.");
            dataAnimals.Rows.Add(2, "Мурка", "Кошка", "Дворовая", "Петров П.П.");
            dataAnimals.Rows.Add(3, "Буренка", "Корова", "Черно-пестрая", "Сидоров С.С.");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataAnimals.SelectedRows.Count > 0)
            {
                SelectedAnimalId = Convert.ToInt32(dataAnimals.SelectedRows[0].Cells["colSelectAnimalId"].Value);
                SelectedAnimalName = dataAnimals.SelectedRows[0].Cells["colSelectAnimalName"].Value.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите животное", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}