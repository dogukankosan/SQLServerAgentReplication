using AsyenUI.Classes;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace AsyenUI.Forms
{
    public partial class SQLQuerySettings : XtraForm
    {
        public SQLQuerySettings()
        {
            InitializeComponent();
        }
        private void SQLQuerySettings_Load(object sender, EventArgs e)
        {
            DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT ID,Name AS 'Sorgu Ismi',Query AS 'Sorgu',CASE WHEN IsActive = 1 THEN 'Aktif'ELSE 'Pasif' END AS 'Aktif_Pasif' FROM  SQLQuerys;");
            gridControl1.DataSource = dt;
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryDesigner cs = new QueryDesigner(0);
            cs.ShowDialog();
            DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT ID,Name AS 'Sorgu Ismi',Query AS 'Sorgu',CASE WHEN IsActive = 1 THEN 'Aktif'ELSE 'Pasif' END AS 'Aktif_Pasif' FROM  SQLQuerys;");
            gridControl1.DataSource = dt;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == XtraMessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?",
                                          "Silme Onayı",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning))
                {
                    int idValue = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
                    _ = SQLLiteCRUD.InserUpdateDelete("DELETE FROM SQLQuerys WHERE ID=" + idValue + "", "Sorguyu Silme İşlemi Başarılı");
                    DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT ID,Name AS 'Sorgu Ismi',Query AS 'Sorgu',CASE WHEN IsActive = 1 THEN 'Aktif'ELSE 'Pasif' END AS 'Aktif_Pasif' FROM  SQLQuerys;");
                    gridControl1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.Message);
            }

        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idValue = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
                QueryDesigner cs = new QueryDesigner(idValue);
                cs.ShowDialog();
                DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT ID,Name AS 'Sorgu Ismi',Query AS 'Sorgu',CASE WHEN IsActive = 1 THEN 'Aktif'ELSE 'Pasif' END AS 'Aktif_Pasif' FROM  SQLQuerys;");
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.Message);
            }
        }
        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idValue = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
                _ = SQLLiteCRUD.InserUpdateDelete("UPDATE SQLQuerys SET IsActive=1 WHERE ID=" + idValue + "", "Sorguyu Aktif İşlemi Başarılı");
                DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT ID,Name AS 'Sorgu Ismi',Query AS 'Sorgu',CASE WHEN IsActive = 1 THEN 'Aktif'ELSE 'Pasif' END 'Aktif_Pasif' FROM  SQLQuerys;");
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.Message);
            }
        }
        private void passiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idValue = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
                _ = SQLLiteCRUD.InserUpdateDelete("UPDATE SQLQuerys SET IsActive=0 WHERE ID=" + idValue + "", "Sorguyu Pasif İşlemi Başarılı");
                DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT ID,Name AS 'Sorgu Ismi',Query AS 'Sorgu',CASE WHEN IsActive = 1 THEN 'Aktif'ELSE 'Pasif' END AS 'Aktif_Pasif' FROM  SQLQuerys;");
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.Message);
            }
        }
    }
}