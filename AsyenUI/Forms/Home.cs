using AsyenUI.Classes;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace AsyenUI.Forms
{
    public partial class Home : XtraForm
    {
        public Home()
        {
            InitializeComponent();
        }
        private void CompanyInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CompanyInfo cs = new CompanyInfo();
            cs.ShowDialog();
        }
        private void SqlConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnectionSettings cs = new SqlConnectionSettings();
            cs.ShowDialog();
        }
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void mailBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailSettings ms = new MailSettings();
            ms.ShowDialog();
        }
        private void sqlQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLQuerySettings cs = new SQLQuerySettings();
            cs.ShowDialog();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt2 = SQLCRUD.LoadDataIntoGridView("SELECT 1");
                if (dt2 is null)
                    throw new Exception();
            }
            catch (Exception)
            {
                SqlConnectionSettings cs = new SqlConnectionSettings();
                cs.ShowDialog();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://asyen.com.tr/") { UseShellExecute = true });
        }
    }
}