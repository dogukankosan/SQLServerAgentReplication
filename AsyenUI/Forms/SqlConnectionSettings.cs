using AsyenUI.Classes;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AsyenUI.Forms
{
    public partial class SqlConnectionSettings : DevExpress.XtraEditors.XtraForm
    {
        public SqlConnectionSettings()
        {
            InitializeComponent();
        }
        private bool formStatus = false;
        private void SqlConnectionSettings_Load(object sender, EventArgs e)
        {
            DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT * FROM SQLConnectionString LIMIT 1");
            if (!(string.IsNullOrEmpty(dt.Rows[0][0].ToString())))
            {
                formStatus = true;
                for (byte i = 0; i < dt.Rows.Count; i++)
                {
                    string[] parameters = EncryptionHelper.Decrypt(dt.Rows[i][0].ToString()).Split(';');
                    List<string> resultList = new List<string>();
                    foreach (string parameter in parameters)
                    {
                        if (!string.IsNullOrEmpty(parameter))
                        {
                            string[] keyValue = parameter.Split('=');
                            string key = keyValue[0].Trim();
                            string value = keyValue.Length > 1 ? keyValue[1].Trim() : string.Empty;
                            if (key == "Server" || key == "Database" || key == "User Id" || key == "Password")
                            {
                                resultList.Add(value);
                            }
                        }
                    }
                    txt_ServerName.Text = resultList[0];
                    txt_DatabaseName.Text = resultList[1];
                    txt_LoginName.Text = resultList[2];
                    txt_Password.Text = resultList[3];
                }
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SQLLiteCRUD.ConnectionStringControlAdd(txt_ServerName.Text, txt_LoginName.Text, txt_Password.Text, txt_DatabaseName.Text);
        }
        private void SqlConnectionSettings_FormClosing(object sender,FormClosingEventArgs e)
        {
            if (!formStatus)
            {
                if (string.IsNullOrWhiteSpace(txt_DatabaseName.Text) || string.IsNullOrWhiteSpace(txt_ServerName.Text) || string.IsNullOrWhiteSpace(txt_LoginName.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
                {
                    XtraMessageBox.Show("Metin Kutuların Tamamını Doldurulmalıdır !!", "Hatalı Veri Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    bool status = SQLLiteCRUD.ConnectionStringControlAdd(txt_ServerName.Text, txt_LoginName.Text, txt_Password.Text, txt_DatabaseName.Text);
                    if (!status)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                }
            }     
        }
    }
}