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
        private void Login_Load_1(object sender, EventArgs e)
        {
            btn_Eyes.Visible = false;
        }
        private void btn_Noteyes_Click(object sender, EventArgs e)
        {
            txt_Pass.Focus();
            btn_Eyes.Visible = true;
            btn_Noteyes.Visible = false;
            txt_Pass.Properties.PasswordChar = '\0';
        }
        private void btn_Eyes_Click(object sender, EventArgs e)
        {
            txt_Pass.Focus();
            btn_Eyes.Visible = false;
            btn_Noteyes.Visible = true;
            txt_Pass.Properties.PasswordChar = '*';
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Asyen" && txt_Pass.Text == "0212")
            {
                Home hm = new Home();
                this.Hide();
                hm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Giriş İşlemi Başarısız Tekrar Deneyiniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Username.Focus();
            }
        }
    }
}