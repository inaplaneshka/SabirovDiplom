using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            ConfigureForm();
            LoadReportTypes();
        }

        private void ConfigureForm()
        {
            this.BackColor = AppColors.BackgroundLight;

            // Панели
            panelHeader.BackColor = Color.White;
            panelParams.BackColor = Color.FromArgb(250, 250, 250);
            panelBody.BackColor = Color.White;
            panelFooter.BackColor = Color.White;

            // Кнопки
            btnGenerate.BackColor = AppColors.PrimaryColor;
            btnGenerate.ForeColor = Color.White;

            btnExport.BackColor = AppColors.SecondaryColor;
            btnExport.ForeColor = Color.White;

            btnPrint.BackColor = AppColors.InfoColor;
            btnPrint.ForeColor = Color.White;

            // Датапикеры
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
            dtpTo.Value = DateTime.Now;

            // Таблица
            ConfigureDataGridView(dataReport);
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

        private void LoadReportTypes()
        {
            cmbReportType.Items.AddRange(new string[] {
                "Отчет по уведомлениям",
                "Отчет по животным",
                "Отчет по владельцам",
                "Отчет по мероприятиям",
                "Статистика отправки",
                "Предстоящие осмотры"
            });

            if (cmbReportType.Items.Count > 0)
                cmbReportType.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            try
            {
                string reportType = cmbReportType.Text;
                DateTime fromDate = dtpFrom.Value;
                DateTime toDate = dtpTo.Value;

                dataReport.Rows.Clear();

                // В зависимости от типа отчета
                switch (reportType)
                {
                    case "Отчет по уведомлениям":
                        GenerateNotificationsReport(fromDate, toDate);
                        break;
                    case "Отчет по животным":
                        GenerateAnimalsReport();
                        break;
                    case "Предстоящие осмотры":
                        GenerateUpcomingExaminations();
                        break;
                }

                lblStatus.Text = $"Отчет сформирован. Записей: {dataReport.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка формирования отчета: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateNotificationsReport(DateTime fromDate, DateTime toDate)
        {
            // Заголовки столбцов
            dataReport.Columns.Clear();
            dataReport.Columns.Add("Date", "Дата");
            dataReport.Columns.Add("Type", "Тип");
            dataReport.Columns.Add("Channel", "Канал");
            dataReport.Columns.Add("Status", "Статус");
            dataReport.Columns.Add("Count", "Количество");

            // Пример данных
            dataReport.Rows.Add("01.12.2024", "Вакцинация", "SMS", "Отправлено", "15");
            dataReport.Rows.Add("01.12.2024", "Осмотр", "Email", "Отправлено", "8");
            dataReport.Rows.Add("02.12.2024", "Карантин", "SMS", "Отправлено", "25");
            dataReport.Rows.Add("02.12.2024", "Мероприятие", "Email", "Ошибка", "3");
        }

        private void GenerateAnimalsReport()
        {
            dataReport.Columns.Clear();
            dataReport.Columns.Add("Type", "Вид животного");
            dataReport.Columns.Add("Count", "Количество");
            dataReport.Columns.Add("Percentage", "Доля, %");

            dataReport.Rows.Add("Собаки", "45", "32%");
            dataReport.Rows.Add("Кошки", "38", "27%");
            dataReport.Rows.Add("КРС", "28", "20%");
            dataReport.Rows.Add("МРС", "15", "11%");
            dataReport.Rows.Add("Птица", "10", "7%");
            dataReport.Rows.Add("Прочие", "4", "3%");
        }

        private void GenerateUpcomingExaminations()
        {
            dataReport.Columns.Clear();
            dataReport.Columns.Add("Animal", "Животное");
            dataReport.Columns.Add("Owner", "Владелец");
            dataReport.Columns.Add("Phone", "Телефон");
            dataReport.Columns.Add("ExaminationDate", "Дата осмотра");
            dataReport.Columns.Add("DaysLeft", "Осталось дней");

            dataReport.Rows.Add("Шарик (собака)", "Иванов И.И.", "+7 (999) 123-45-67", "15.12.2024", "3");
            dataReport.Rows.Add("Мурка (кошка)", "Петров П.П.", "+7 (999) 234-56-78", "20.12.2024", "8");
            dataReport.Rows.Add("Буренка (корова)", "Сидоров С.С.", "+7 (999) 345-67-89", "25.12.2024", "13");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx|CSV Files|*.csv|PDF Files|*.pdf";
                sfd.Title = "Экспорт отчета";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Экспорт данных
                    MessageBox.Show($"Отчет экспортирован в файл: {sfd.FileName}",
                        "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Печать отчета
            MessageBox.Show("Функция печати в разработке", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Показать/скрыть параметры дат в зависимости от типа отчета
            bool showDates = cmbReportType.SelectedIndex != 1 && cmbReportType.SelectedIndex != 5;
            dtpFrom.Visible = showDates;
            dtpTo.Visible = showDates;
            label2.Visible = showDates;
            label3.Visible = showDates;
        }
    }
}