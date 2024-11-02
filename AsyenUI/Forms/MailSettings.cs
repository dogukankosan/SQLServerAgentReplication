using AsyenUI.Bussines;
using AsyenUI.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.Data;
using System.Windows.Forms;

namespace AsyenUI.Forms
{
    public partial class MailSettings : XtraForm
    {
        public MailSettings()
        {
            InitializeComponent();
        }
        private bool status = false;
        private void btn_SendMail_Click(object sender, EventArgs e)
        {
            if (EMailManager.EmailControl(txt_Email, txt_recipientEmail, txt_Password, txt_Server, txt_Port))
            {
                try
                {
                    int port = int.Parse(txt_Port.Text);
                    _ = MailSender.MailSendForm(txt_Email.Text, txt_recipientEmail.Text, txt_Password.Text, txt_Server.Text, port, chk_SSL.Checked);
                    status = true;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextLog.TextLogging(ex.Message);
                }
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (EMailManager.EmailControl(txt_Email, txt_recipientEmail, txt_Password, txt_Server, txt_Port))
                {
                    _ = SQLLiteCRUD.InserUpdateDelete("UPDATE MailSettings SET MailAdress='" + txt_Email.Text + "',ReceiverMail='" + txt_recipientEmail.Text + "',Password='" + EncryptionHelper.Encrypt(txt_Password.Text) + "',ServerName='" + txt_Server.Text + "',Port=" + txt_Port.Text + ",SSl=" + chk_SSL.Checked + "", "Mail Güncelleme İşlemi Başarılı");
                }
            }
            else
            {
                XtraMessageBox.Show("Önce Mailinizi Test Ediniz !!", "Mail Test Et", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MailSettings_Load(object sender, EventArgs e)
        {
            txt_Port.Properties.Mask.MaskType = MaskType.Numeric;
            txt_Port.Properties.Mask.EditMask = "d";
            txt_Port.Properties.Mask.UseMaskAsDisplayFormat = true;
            DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT * FROM MailSettings LIMIT 1");
            for (byte i = 0; i < dt.Rows.Count; i++)
            {
                txt_Email.Text = dt.Rows[i][0].ToString();
                txt_recipientEmail.Text = dt.Rows[i][1].ToString();
                txt_Password.Text = EncryptionHelper.Decrypt(dt.Rows[i][2].ToString());
                txt_Server.Text = dt.Rows[i][3].ToString();
                txt_Port.Text = dt.Rows[i][4].ToString();
                chk_SSL.Checked = Convert.ToBoolean(dt.Rows[i][5]);
            }
        }
    }
}