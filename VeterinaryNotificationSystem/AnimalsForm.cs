using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class AnimalsForm : Form
    {
        public AnimalsForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadAnimals();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;

            // Панели
            panelHeader.BackColor = Color.White;
            panelFooter.BackColor = Color.White;

            // Кнопки
            btnAdd.BackColor = AppColors.PrimaryColor;
            btnAdd.ForeColor = Color.White;

            btnEdit.BackColor = AppColors.SecondaryColor;
            btnEdit.ForeColor = Color.White;

            btnDelete.BackColor = AppColors.DangerColor;
            btnDelete.ForeColor = Color.White;

            btnSearch.BackColor = AppColors.InfoColor;
            btnSearch.ForeColor = Color.White;

            // Таблица
            ConfigureDataGridView(dataAnimals);
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = AppColors.PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            dgv.RowHeadersDefaultCellStyle.BackColor = AppColors.PrimaryLight;
            dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9F);
        }

        private void LoadAnimals()
        {
            dataAnimals.Rows.Clear();

            // Пример данных
            dataAnimals.Rows.Add(
                1,
                "Шарик",
                "Собака домашняя",
                "Овчарка",
                "Иванов И.И.",
                "01.01.2020",
                "01.01.2024",
                "01.01.2025",
                "Активно"
            );

            dataAnimals.Rows.Add(
                2,
                "Мурка",
                "Кошка домашняя",
                "Дворовая",
                "Петров П.П.",
                "15.05.2021",
                "15.05.2023",
                "15.05.2024",
                "Активно"
            );
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AnimalEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAnimals();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataAnimals.SelectedRows.Count > 0)
            {
                int animalId = Convert.ToInt32(dataAnimals.SelectedRows[0].Cells["colAnimalId"].Value);
                var form = new AnimalEditForm(animalId);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadAnimals();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataAnimals.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранное животное?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LoadAnimals();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                // Поиск в базе данных
            }
        }
    }
}