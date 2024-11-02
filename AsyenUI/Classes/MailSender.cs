using DevExpress.XtraEditors;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyenUI.Classes
{
    internal class MailSender
    {
        internal async static Task MailSendForm(string senderEmail, string recipientEmail, string senderPassword, string server, int port, bool ssl)
        {
            string subject = "Asyen Otomatik İşlemler Test E-posta Başlığı";
            string body = "Bu bir test e-posta içeriğidir.";
            try
            {
                using (SmtpClient client = new SmtpClient(server, port))
                {
                    client.EnableSsl = ssl;
                    client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(senderEmail),
                        Subject = subject,
                        Body = body
                    };
                    mail.To.Add(recipientEmail);
                    await client.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("E-Mail gönderilirken bir hata oluştu: " + ex.Message, "Hatalı E-Posta Gönderimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.ToString());
                return;
            }
            XtraMessageBox.Show("E-Mail Başarıyla Gönderildi.", "Başarılı Mail Gönderme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}