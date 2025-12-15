using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadUsers();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;
            ConfigureDataGridView(dataUsers);

            btnAdd.BackColor = AppColors.PrimaryColor;
            btnAdd.ForeColor = Color.White;
            btnEdit.BackColor = AppColors.SecondaryColor;
            btnEdit.ForeColor = Color.White;
            btnDelete.BackColor = AppColors.DangerColor;
            btnDelete.ForeColor = Color.White;
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

        private void LoadUsers()
        {
            dataUsers.Rows.Clear();
            dataUsers.Rows.Add(1, "admin", "Иванов И.И.", "Главный ветеринарный врач", "Admin", "Активен");
            dataUsers.Rows.Add(2, "operator1", "Петров П.П.", "Ветеринарный врач", "Operator", "Активен");
            dataUsers.Rows.Add(3, "viewer1", "Сидоров С.С.", "Лаборант", "Viewer", "Активен");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new UserEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataUsers.SelectedRows.Count > 0)
            {
                var form = new UserEditForm(Convert.ToInt32(dataUsers.SelectedRows[0].Cells["colUserId"].Value));
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataUsers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Удалить выбранного пользователя?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LoadUsers();
                }
            }
        }
    }
}