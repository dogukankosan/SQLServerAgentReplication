using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace AsyenUI.Bussines
{
    internal static class QueryControl
    {
        internal static bool QueryControlBool(TextEdit queryName, RichTextBox query, TextEdit hour)
        {
            if (string.IsNullOrEmpty(queryName.Text))
            {
                XtraMessageBox.Show("Sorgu Adı Kutusu Boş Geçilemez", "Hatalı Sorgu Adı Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                queryName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(query.Text))
            {
                XtraMessageBox.Show("Sorgu Kutusu Boş Geçilemez", "Hatalı Sorgu Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                query.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(hour.Text))
            {
                XtraMessageBox.Show("Kaç Saate Bir Çalışacak Kutusu Boş Geçilemez", "Hatalı Kaç Saate Bir Çalışacak Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hour.Focus();
                return false;
            }
            int value = 0;
            if (int.TryParse(hour.Text, out value))
            {
                if (!(value >= 1 && value <= 24))
                {
                    XtraMessageBox.Show("Kaç Saate Bir Çalışacak Kutusu 1 ile 24 Saat Aralığında Olmalıdır", "Hatalı Kaç Saate Bir Çalışacak Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hour.Focus();
                    return false;
                }
            }
            else
            {
                XtraMessageBox.Show("Kaç Saate Bir Çalışacak Kutusu Sadece Sayısal İfade Girişi Yapınız", "Hatalı Kaç Saate Bir Çalışacak Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hour.Focus();
                return false;
            }
            return true;
        }
    }
}