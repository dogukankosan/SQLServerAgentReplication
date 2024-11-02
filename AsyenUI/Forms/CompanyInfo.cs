using AsyenUI.Classes;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace AsyenUI.Forms
{
    public partial class CompanyInfo : XtraForm
    {
        public CompanyInfo()
        {
            InitializeComponent();
        }
        string tableName = default;
        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            DataTable dt=SQLLiteCRUD.GetDataFromSQLite("SELECT * FROM CompanyInfo LIMIT 1");
            for (byte i = 0; i < dt.Rows.Count; i++)
            {
                txt_TableInfo.Text = dt.Rows[i][0].ToString();
                txt_CompanyName.Text = dt.Rows[i][1].ToString();
            }
            tableName = txt_TableInfo.Text;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TableInfo.Text))
            {
                _ = SQLLiteCRUD.InserUpdateDelete("UPDATE CompanyInfo SET CompanyName='"+txt_CompanyName.Text+"',TableName='" + txt_TableInfo.Text + "'", "Şirket Bilgileri Güncelleme Başarılı");
                if (DialogResult.Yes == XtraMessageBox.Show("Güncellenen Tablo Adı Tüm SQL Komutlarında Değiştirilsin Mi ?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    _ = SQLLiteCRUD.InserUpdateDelete("UPDATE SQLQuerys SET Query=replace(Query,'" + tableName + "','" + txt_TableInfo.Text + "')", "SQL Sorguları Güncelleme Başarılı");
                }
            }
            else
            {
                XtraMessageBox.Show("Tablo Adı Boş Geçilemez !!", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TableInfo.Focus();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            txt_TableInfo.Text = "LG_FFF";
            txt_TableInfo.Focus();
        }
    }
}