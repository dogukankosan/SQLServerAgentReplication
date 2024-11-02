using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Threading.Tasks;

namespace AsyenUI.Classes
{
    internal class MailSender
    {
        internal async static Task MailSendForm(string error)
        {
            DataTable dt;
            DataTable dt2;
            try
            {
                dt = SQLLiteCRUD.GetDataFromSQLite("SELECT * FROM MailSettings LIMIT 1");
                dt2 = SQLLiteCRUD.GetDataFromSQLite("select CompanyName from CompanyInfo LIMIT 1");
            }
            catch (Exception ex)
            {
                string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string logFilePath = Path.Combine(appDirectory, "log.txt");
                Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));
                File.AppendAllText(logFilePath, $"{DateTime.Now}: {ex.Message}\n");
                return;
            }
            if (string.IsNullOrEmpty(dt.Rows[0][0].ToString()) || string.IsNullOrEmpty(dt.Rows[0][1].ToString()) || string.IsNullOrEmpty(dt.Rows[0][2].ToString())
|| string.IsNullOrEmpty(dt.Rows[0][3].ToString()) || string.IsNullOrEmpty(dt.Rows[0][4].ToString()) || string.IsNullOrEmpty(dt.Rows[0][5].ToString()))
            {
                return;
            }
            string body = $"<p>Asyen Otomatik İşlemler <span style='color: red;'>HATALI</span>. Hata Mesajı {error}</p>";
            try
            {
                using (SmtpClient client = new SmtpClient(dt.Rows[0][3].ToString(), int.Parse(dt.Rows[0][4].ToString())))
                {
                    client.EnableSsl = Convert.ToBoolean(int.Parse(dt.Rows[0][5].ToString()));
                    client.Credentials = new NetworkCredential(dt.Rows[0][0].ToString(), EncryptionHelper.Decrypt(dt.Rows[0][2].ToString()));

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(dt.Rows[0][0].ToString()),
                        Subject = dt2.Rows[0][0].ToString() + " Firmanın Otomatik İşlemleri",
                        Body = body,
                        IsBodyHtml = true
                    };
                    mail.To.Add(dt.Rows[0][1].ToString());
                    await client.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                TextLog.TextLogging(ex.ToString());
                return;
            }
        }
    }
}