using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace AsyenUI.Forms
{
    public partial class Login : XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_LoginName.Text == "Asyen" && txt_Password.Text == "0212")
            {
                XtraMessageBox.Show("Giriş İşlemi Başarılı", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home hm = new Home();
                this.Hide();
                hm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Giriş İşlemi Başarısız Tekrar Deneyiniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LoginName.Focus();
            }
        }
        private void btn_NotEye_Click(object sender, EventArgs e)
        {
            txt_Password.Focus();
            btn_Eye.Visible = true;
            btn_NotEye.Visible = false;
            txt_Password.Properties.PasswordChar = '*';
        }
        private void btn_Eye_Click(object sender, EventArgs e)
        {
            txt_Password.Focus();
            btn_Eye.Visible = false;
            btn_NotEye.Visible = true;
            txt_Password.Properties.PasswordChar = '\0';
        }
        private void Login_Load(object sender, EventArgs e)
        {
            btn_NotEye.Visible = false;
        }
    }
}