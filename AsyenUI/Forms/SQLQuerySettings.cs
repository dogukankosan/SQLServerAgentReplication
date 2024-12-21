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
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            gridView1.OptionsSelection.EnableAppearanceFocusedRow = true;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
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
        private async void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string queryValues = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
                string activePassive = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
                if (activePassive != "Aktif")
                {
                    XtraMessageBox.Show("Sadece aktif durumdaki sorgular test edilebilir.","Hatalı işlem",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool status = await SQLCRUD.InserUpdateDelete(queryValues);
                if (status)
                    XtraMessageBox.Show("Sorgu başarılı bir şekilde çalıştı.", "Başarılı veritabanı işlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.Message);
            }
        }
    }
}