using AsyenUI.Bussines;
using AsyenUI.Classes;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AsyenUI.Forms
{
    public partial class QueryDesigner : XtraForm
    {
        private int _id;
        public QueryDesigner(int id)
        {
            InitializeComponent();
            _id = id;
        }
        private void QueryDesigner_Load(object sender, EventArgs e)
        {
            txt_Hour.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txt_Hour.Properties.Mask.EditMask = "d";
            txt_Hour.Properties.Mask.UseMaskAsDisplayFormat = true;
            rch_Query.Font = new Font("Consolas", 12);
            if (_id > 0)
            {
                this.Text = "Sorgu Güncelleme Ekranı";
                DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT * FROM SQLQuerys WHERE ID=" + _id + "");
                for (byte i = 0; i < dt.Rows.Count; i++)
                {
                    txt_QueryName.Text = dt.Rows[i][1].ToString();
                    rch_Query.Text = dt.Rows[i][2].ToString();
                    tmt_Startdate.EditValue = dt.Rows[i][4].ToString();
                    txt_Hour.Text = dt.Rows[i][5].ToString();
                    chk_Monday.Checked = dt.Rows[0][6].ToString().Contains("Pazartesi") ? true : false;
                    chk_Tuesday.Checked = dt.Rows[0][6].ToString().Contains("Salı") ? true : false;
                    chk_Wednesday.Checked = dt.Rows[0][6].ToString().Contains("Çarşamba") ? true : false;
                    chk_Thursday.Checked = dt.Rows[0][6].ToString().Contains("Perşembe") ? true : false;
                    chk_Friday.Checked = dt.Rows[0][6].ToString().Split(',').Any(day => day.Trim() == "Cuma");
                    chk_Saturday.Checked = dt.Rows[0][6].ToString().Contains("Cumartesi") ? true : false;
                    chk_Sunday.Checked = dt.Rows[0][6].ToString().Split(',').Any(day => day.Trim() == "Pazar");
                }
            }
            else
            {
                this.Text = "Sorgu Ekleme Ekranı";
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (QueryControl.QueryControlBool(txt_QueryName, rch_Query, txt_Hour))
            {
                if (chk_Monday.Checked == false && chk_Tuesday.Checked == false && chk_Wednesday.Checked == false && chk_Thursday.Checked == false && chk_Friday.Checked == false && chk_Saturday.Checked == false && chk_Sunday.Checked == false)
                {
                    XtraMessageBox.Show("Günlerden En Az Biri Seçilmelidir", "Hatalı Gün Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string days = default;
                    days += chk_Monday.Checked ? "Pazartesi," : "";
                    days += chk_Tuesday.Checked ? "Salı," : "";
                    days += chk_Wednesday.Checked ? "Çarşamba," : "";
                    days += chk_Thursday.Checked ? "Perşembe," : "";
                    days += chk_Friday.Checked ? "Cuma," : "";
                    days += chk_Saturday.Checked ? "Cumartesi," : "";
                    days += chk_Sunday.Checked ? "Pazar," : "";
                    if (days.Length > 0)
                        days = days.Substring(0, days.Length - 1);
                    if (_id > 0)
                    {
                        string query = "UPDATE SQLQuerys SET Name=@name, Query=@query, StartDate=@startDate, Step=@step, Days=@days, LastStepDate=@lastStepDate WHERE ID=@id";
                        _ = SQLLiteCRUD.InserUpdateDeleteParameter(query, new SQLiteParameter[]
                        {
        new SQLiteParameter("@name", txt_QueryName.Text),
        new SQLiteParameter("@query", rch_Query.Text),
        new SQLiteParameter("@startDate", tmt_Startdate.Text),
        new SQLiteParameter("@step", txt_Hour.Text),
        new SQLiteParameter("@days", days),
        new SQLiteParameter("@lastStepDate",""),
        new SQLiteParameter("@id", _id)
                        }, "Sorgu Güncelleme İşlemi Başarılı");
                        this.Close();
                    }
                    else
                    {
                        string query = "INSERT INTO SQLQuerys (Name, Query, IsActive, StartDate, Step, Days, LastStepDate) VALUES (@name, @query, 0, @startDate, @step, @days, @lastStepDate)";
                        _ = SQLLiteCRUD.InserUpdateDeleteParameter(query, new SQLiteParameter[]
                        {
        new SQLiteParameter("@name", txt_QueryName.Text),
        new SQLiteParameter("@query", rch_Query.Text),
        new SQLiteParameter("@startDate", tmt_Startdate.Text),
        new SQLiteParameter("@step", txt_Hour.Text),
        new SQLiteParameter("@days", days),
        new SQLiteParameter("@lastStepDate","")
                        }, "Sorgu Kaydetme İşlemi Başarılı");
                        this.Close();
                    }
                }
            }
        }
        private void txt_Hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}