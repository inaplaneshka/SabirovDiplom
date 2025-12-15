using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class SelectEmployeeForm : Form
    {
        public string SelectedEmployeeName { get; private set; }
        public int SelectedEmployeeId { get; private set; }

        public SelectEmployeeForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadEmployees();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;

            // Конфигурация DataGridView
            dataEmployees.BackgroundColor = Color.White;
            dataEmployees.BorderStyle = BorderStyle.None;
            dataEmployees.EnableHeadersVisualStyles = false;

            dataEmployees.ColumnHeadersDefaultCellStyle.BackColor = AppColors.PrimaryColor;
            dataEmployees.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Кнопки
            btnSelect.BackColor = AppColors.PrimaryColor;
            btnSelect.ForeColor = Color.White;
            btnCancel.BackColor = AppColors.SecondaryColor;
            btnCancel.ForeColor = Color.White;
        }

        private void LoadEmployees()
        {
            dataEmployees.Rows.Clear();

            // Пример данных сотрудников
            dataEmployees.Rows.Add(1, "Иванов Иван Иванович", "Главный ветеринарный врач", "Admin");
            dataEmployees.Rows.Add(2, "Петров Петр Петрович", "Ветеринарный врач", "Operator");
            dataEmployees.Rows.Add(3, "Сидорова Мария Ивановна", "Лаборант", "Viewer");
            dataEmployees.Rows.Add(4, "Кузнецов Алексей Викторович", "Техник", "Operator");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataEmployees.SelectedRows.Count > 0)
            {
                SelectedEmployeeId = Convert.ToInt32(dataEmployees.SelectedRows[0].Cells["colEmployeeId"].Value);
                SelectedEmployeeName = dataEmployees.SelectedRows[0].Cells["colEmployeeName"].Value.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите сотрудника", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            // Фильтрация списка сотрудников
        }
    }
}