using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace AsyenUI.Classes
{
    internal static class SQLCRUD
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnectionString"].ConnectionString;
        internal static string GetDataFromSQLiteConnection()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("SELECT  ConnectionString FROM SQLConnectionString LIMIT 1", connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return EncryptionHelper.Decrypt(reader["ConnectionString"].ToString());
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    TextLog.TextLogging(ex.Message);
                    return null;
                }
            }
        }
        internal static async Task InserUpdateDelete(string query)
        {
            using (SqlConnection conn = new SqlConnection(GetDataFromSQLiteConnection()))
            {
                try
                {
                    await conn.OpenAsync();
                    string[] commands = query.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string command in commands)
                    {
                        string cleanCommand = command.Replace("\n", " ").Replace("\r", " ").Trim();
                        if (!string.IsNullOrWhiteSpace(cleanCommand))
                        {
                            using (SqlCommand cmd = new SqlCommand(cleanCommand, conn))
                            {
                                cmd.CommandTimeout = 120;
                                await cmd.ExecuteNonQueryAsync();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    TextLog.TextLogging(ex.Message);
                }
            }
        }
    }
}