using AsyenUI.Classes;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

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
        private void serviceSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string installUtilPath = Interaction.InputBox("İlgili .Net Sürümü Yoksa Kurunuz v4.0.30319", "Kontrol Ediniz:", @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe");
                string serviceExePath = Interaction.InputBox("Servis Uygulamasının Kurulu Olduğu Dizin:", "Giriniz:", @"DosyaYolu\AsyenOtomatikIslemler\AsyenService");

                if (string.IsNullOrWhiteSpace(serviceExePath))
                {
                    XtraMessageBox.Show("Geçerli Bir Servis Dizini Girmelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = installUtilPath,
                    Arguments = $"\"{serviceExePath + "\\AsyenService.exe"}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (process.ExitCode == 0 && string.IsNullOrEmpty(error))
                    {
                        XtraMessageBox.Show($"Servis Başarıyla Kaydedildi.\nÇıktı: {output}", "Servis Kaydı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var configFile = serviceExePath + "\\AsyenService.exe.config";
                        XDocument configXml = XDocument.Load(configFile);
                        var connectionStrings = configXml.Root.Element("connectionStrings");
                        if (connectionStrings != null)
                        {
                            var connectionStringElement = connectionStrings.Elements("add").FirstOrDefault(x => x.Attribute("name").Value == "SQLiteConnectionString");
                            if (connectionStringElement != null)
                            {
                                connectionStringElement.Attribute("connectionString").Value = SQLLiteCRUD.connectionString;
                                configXml.Save(configFile);
                            }
                            else
                            {
                                XtraMessageBox.Show("Connection String Bulunamadı.", "SQLITE Connection String Kaydedilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                TextLog.TextLogging("Servis Confige ConnectionString Kaydedilemedi");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("ConnectionStrings Bölümü Bulunamadı.", "SQLITE Connection String Kaydedilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TextLog.TextLogging("Servis Confige ConnectionString Kaydedilemedi Yada Bulamadı");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show($"Servis kaydedilemedi.\nHata: {error}\nÇıktı: {output}", "Servis Kaydı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextLog.TextLogging("Servis Confige ConnectionString Kaydedilemedi Yada Bulamadı");
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hatalı Servis Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.Message);
            }
        }
        private void serviceStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string serviceName = "Asyen Servis";
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c sc query \"{serviceName}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (!output.Contains("RUNNING"))
                {
                    process.StartInfo.Arguments = $"/c net start \"{serviceName}\"";
                    process.Start();
                    output = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (string.IsNullOrEmpty(error))
                        XtraMessageBox.Show($"Servis Başarıyla Başlatıldı.\nÇıktı: {output}", "Servis Başlatma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        XtraMessageBox.Show($"Servis Başlatılamadı.\nHata: {error}", "Servis Başlatma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextLog.TextLogging(error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Servis Zaten Çalışıyor.", "Servis Durumu Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextLog.TextLogging(error);
                }
            }
        }
        private void serviceStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string serviceName = "Asyen Servis";
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c sc query \"{serviceName}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (output.Contains("RUNNING"))
                {
                    process.StartInfo.Arguments = $"/c net stop \"{serviceName}\"";
                    process.Start();
                    output = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (process.ExitCode == 0 && string.IsNullOrEmpty(error))
                        XtraMessageBox.Show($"Servis Başarıyla Durduruldu.\nÇıktı: {output}", "Servis Durdurma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        XtraMessageBox.Show($"Servis Durdurulamadı.\nHata: {error}", "Servis Durdurma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextLog.TextLogging(error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Servis Zaten Durdurulmuş.", "Servis Durumu Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void serviceDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string serviceName = "Asyen Servis";
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c sc query \"{serviceName}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (output.Contains("RUNNING"))
                {
                    process.StartInfo.Arguments = $"/c net stop \"{serviceName}\"";
                    process.Start();
                    output = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (string.IsNullOrEmpty(error))
                        XtraMessageBox.Show($"Servis Başarıyla Durduruldu.\nÇıktı: {output}", "Servis Durdurma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        XtraMessageBox.Show($"Servis Durdurulamadı.\nHata: {error}", "Servis Durdurma Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextLog.TextLogging(error);
                        return;
                    }
                }
                else
                    XtraMessageBox.Show("Servis Zaten Durdurulmuş.", "Servis Durumu Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                process.StartInfo.Arguments = $"/c sc delete \"{serviceName}\"";
                process.Start();
                output = process.StandardOutput.ReadToEnd();
                error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (string.IsNullOrEmpty(error))
                    XtraMessageBox.Show($"Servis Başarıyla Silindi.\nÇıktı: {output}", "Servis Silme Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    XtraMessageBox.Show($"Servis Silinemedi.\nHata: {error}", "Servis Silme Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextLog.TextLogging(error);
                }
            }
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
                DataTable dt = SQLLiteCRUD.GetDataFromSQLite("select 1");
                if (dt.Rows.Count < 1)
                {
                    XtraMessageBox.Show("SQLLITE Bağlantısı Hatalı Lütfen Kontrol Ediniz", "Hatalı Bağlantı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hatalı Bağlantı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextLog.TextLogging(ex.Message);
                Application.Exit();
            }
            try
            {
                DataTable dt2 = SQLCRUD.LoadDataIntoGridView("SELECT 1");
                if (dt2 is null)
                {
                    throw new Exception();
                }
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