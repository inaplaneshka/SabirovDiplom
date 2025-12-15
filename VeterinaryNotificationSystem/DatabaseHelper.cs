using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeterinaryNotificationSystem
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["VeterinaryDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void LogAction(string action, int? employeeId = null)
        {
            try
            {
                using (var connection = GetConnection())
                using (var command = new SqlCommand(
                    "INSERT INTO SystemLogs (LogLevel, Source, Message, EmployeeID) VALUES (@Level, @Source, @Message, @EmployeeID)",
                    connection))
                {
                    command.Parameters.AddWithValue("@Level", "INFO");
                    command.Parameters.AddWithValue("@Source", "Application");
                    command.Parameters.AddWithValue("@Message", action);
                    command.Parameters.AddWithValue("@EmployeeID", employeeId.HasValue ? (object)employeeId.Value : DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                // Игнорируем ошибки логирования
            }
        }
    }
}