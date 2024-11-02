using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace AsyenUI.Classes
{
    internal class SQLLiteCRUD
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnectionString"].ConnectionString;
        public static DataTable GetDataFromSQLite(string query)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    TextLog.TextLogging(ex.Message);
                    return null;
                }
                connection.Close();
            }
            return dataTable;
        }
        internal static async Task InserUpdateDelete(string query)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    TextLog.TextLogging(ex.Message);
                }
            }
        }
    }
}