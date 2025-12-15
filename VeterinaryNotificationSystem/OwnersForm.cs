using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class OwnersForm : Form
    {
        public OwnersForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadOwners();
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
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.EnableHeadersVisualStyles = false;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = AppColors.PrimaryColor;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            dataGridView.RowHeadersDefaultCellStyle.BackColor = AppColors.PrimaryLight;
            dataGridView.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9F);
        }

        private void LoadOwners()
        {
            // Загрузка данных из базы
            // Временные данные для демонстрации
            dataGridView.Rows.Add(1, "Иванов Иван Иванович", "+7 (999) 123-45-67", "г. Острогожск, ул. Ленина, 1", "Физическое лицо");
            dataGridView.Rows.Add(2, "Петров Петр Петрович", "+7 (999) 234-56-78", "с. Петровка, ул. Центральная, 10", "Физическое лицо");
            dataGridView.Rows.Add(3, "ООО 'Агроферма'", "+7 (999) 345-67-89", "д. Новоселовка", "Юридическое лицо");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new OwnerEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Добавление нового владельца
                LoadOwners();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int ownerId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["colId"].Value);
                var form = new OwnerEditForm(ownerId);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadOwners();
                }
            }
            else
            {
                MessageBox.Show("Выберите владельца для редактирования", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранного владельца?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Удаление владельца из базы данных
                    LoadOwners();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                // Поиск в базе данных
                MessageBox.Show($"Поиск: {searchText}", "Поиск",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}