using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadEvents();
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
            ConfigureDataGridView(dataEvents);

            // Календарь
            monthCalendar.BackColor = Color.White;
            monthCalendar.TitleBackColor = AppColors.PrimaryColor;
            monthCalendar.TitleForeColor = Color.White;
            monthCalendar.TrailingForeColor = Color.FromArgb(180, 180, 180);
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

        private void LoadEvents()
        {
            dataEvents.Rows.Clear();

            // Пример данных
            dataEvents.Rows.Add(
                1,
                "Массовая вакцинация собак",
                "Вакцинация",
                "15.12.2024",
                "17.12.2024",
                "г. Острогожск, ул. Ветеринарная, 5",
                "Иванов И.И.",
                "Запланировано"
            );

            dataEvents.Rows.Add(
                2,
                "Плановый осмотр КРС",
                "Осмотр",
                "20.12.2024",
                "20.12.2024",
                "с. Петровка",
                "Петров П.П.",
                "В процессе"
            );
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new EventEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEvents();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataEvents.SelectedRows.Count > 0)
            {
                int eventId = Convert.ToInt32(dataEvents.SelectedRows[0].Cells["colEventId"].Value);
                var form = new EventEditForm(eventId);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadEvents();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataEvents.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранное мероприятие?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LoadEvents();
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

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Загрузка мероприятий на выбранную дату
        }
    }
}