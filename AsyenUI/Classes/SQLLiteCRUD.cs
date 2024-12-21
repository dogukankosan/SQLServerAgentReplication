using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyenUI.Classes
{
    internal class SQLLiteCRUD
    {
        internal static string connectionString = $"Data Source={Application.StartupPath}\\Database\\Settings.db;Version=3;";
        internal static DataTable GetDataFromSQLite(string query)
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
        internal static async Task InserUpdateDelete(string query, string message)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    await cmd.ExecuteNonQueryAsync();
                    XtraMessageBox.Show(message, "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Hatalı SQLLite İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextLog.TextLogging(ex.Message);
                }
            }
        }
        internal static async Task InserUpdateDeleteParameter(string query, SQLiteParameter[] a, string message)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddRange(a);
                    await cmd.ExecuteNonQueryAsync();
                    XtraMessageBox.Show(message, "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Hatalı SQLLite İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextLog.TextLogging(ex.Message);
                }
            }
        }
        internal static bool ConnectionStringControlAdd(string serverName, string loginName, string password, string databaseName)
        {
            string connectionString = $"Server={serverName};Database={databaseName};User Id ={loginName}; Password={password};Connection Timeout=10;TrustServerCertificate=True;Max Pool Size=100;Min Pool Size=5;Pooling=true;";
            SqlConnection sqLConnection = new SqlConnection(connectionString);
            try
            {
                sqLConnection.Open();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "Hatalı Veri Tabanı Bağlantısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            sqLConnection.Close();
            _ = SQLLiteCRUD.InserUpdateDelete("UPDATE SQLConnectionString SET ConnectionString='" + EncryptionHelper.Encrypt(connectionString) + "'", "Veri Tabanı Bağlantısı Başarılı");
            return true;
        }
    }
}