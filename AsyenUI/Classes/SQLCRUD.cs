using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AsyenUI.Classes
{
    internal static class SQLCRUD
    {
        internal static string GetDataFromSQLiteConnection()
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={Application.StartupPath}\\Database\\Settings.db;Version=3;"))
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
                                return reader["ConnectionString"].ToString();
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Hatalı Veri Çekme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextLog.TextLogging(ex.Message);
                    return null;
                }
            }
        }
        internal static DataTable LoadDataIntoGridView(string query)
        {
            using (SqlConnection conn = new SqlConnection(EncryptionHelper.Decrypt(SQLCRUD.GetDataFromSQLiteConnection())))
            {
                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        return dt;
                    }
                }
                catch (Exception e)
                {
                    TextLog.TextLogging(e.Message);
                }
            }
            return null;
        }
        internal static async Task<bool> InserUpdateDelete(string query)
        {
            using (SqlConnection conn = new SqlConnection(EncryptionHelper.Decrypt(GetDataFromSQLiteConnection())))
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
                    return true; 
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Hatalı veritabanı işlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextLog.TextLogging(ex.Message); 
                    return false;
                }
            }
        }
    }
}