using AsyenUI.Classes;
using AsyenUI.Forms;
using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

class Program
{
    [STAThread]
    static async Task Main(string[] args)
    {
        try
        {// Programın adıyla çalışan bir örneğin olup olmadığını kontrol ediyoruz
            string processName = Process.GetCurrentProcess().ProcessName;
            var runningProcesses = Process.GetProcessesByName(processName);
            if (runningProcesses.Length > 1)
            {
                XtraMessageBox.Show("Program zaten açık!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Servis kurulu mu?
            if (IsServiceInstalled("Asyen Otomatik Islemler Servisi"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
                return;
            }
            // Yönetici yetkisi kontrolü
            if (!IsAdministrator())
            {
                XtraMessageBox.Show("Servis kurulu değil. Lütfen programı yönetici olarak çalıştırın.", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Yönetici yetkisiyle servis kurulum işlemleri
            string installUtilPath = @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe";
            if (!await ServiceExistsAsync("Asyen Otomatik Islemler Servisi"))
            {
                await InstallServiceAsync(installUtilPath, "Service\\AsyenService.exe");
                await UpdateConnectionStringAsync(Path.Combine("Service\\AsyenService.exe.config"));
            }
            // Servisi başlat
            await StartServiceAsync("Asyen Otomatik Islemler Servisi");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private static bool IsAdministrator()
    {
        WindowsIdentity identity = WindowsIdentity.GetCurrent();
        WindowsPrincipal principal = new WindowsPrincipal(identity);
        return principal.IsInRole(WindowsBuiltInRole.Administrator);
    }
    private static bool IsServiceInstalled(string serviceName)
    {
        ServiceController[] services = ServiceController.GetServices();
        return services.Any(service => service.ServiceName.Equals(serviceName, StringComparison.OrdinalIgnoreCase));
    }
    private static async Task<bool> ServiceExistsAsync(string serviceName)
    {
        ProcessStartInfo sc = new ProcessStartInfo
        {
            FileName = "sc",
            Arguments = $"query {serviceName}",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        using (Process process = new Process())
        {
            process.StartInfo = sc;
            process.Start();
            string output = await process.StandardOutput.ReadToEndAsync();
            await Task.Run(() => process.WaitForExit());
            return output.Contains("RUNNING") || output.Contains("STOPPED");
        }
    }
    private static async Task InstallServiceAsync(string installUtilPath, string servicePath)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = installUtilPath,
            Arguments = $"\"{Path.Combine(servicePath)}\"",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        using (Process process = new Process())
        {
            process.StartInfo = startInfo;
            process.Start();
            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();
            await Task.Run(() => process.WaitForExit());
            if (process.ExitCode != 0 || !string.IsNullOrEmpty(error))
                throw new Exception($"Servis kaydedilemedi.\nHata: {error}\nÇıktı: {output}");
        }
    }
    private static async Task StartServiceAsync(string serviceName)
    {
        try
        {
            using (ServiceController sc = new ServiceController(serviceName))
            {
                if (sc.Status == ServiceControllerStatus.Stopped || sc.Status == ServiceControllerStatus.Paused)
                {
                    sc.Start();
                    await Task.Run(() => sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30)));
                }
                else
                    XtraMessageBox.Show("Servis zaten çalışıyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Servis başlatılırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private static async Task UpdateConnectionStringAsync(string configFilePath)
    {
        try
        {
            XDocument configXml = await Task.Run(() => XDocument.Load(configFilePath));
            XElement connectionStrings = configXml.Root.Element("connectionStrings");
            if (connectionStrings != null)
            {
                XElement connectionStringElement = connectionStrings.Elements("add")
                    .FirstOrDefault(x => x.Attribute("name").Value == "SQLiteConnectionString");
                if (connectionStringElement != null)
                {
                    connectionStringElement.Attribute("connectionString").Value = SQLLiteCRUD.connectionString;
                    await Task.Run(() => configXml.Save(configFilePath));
                }
                else
                    XtraMessageBox.Show("Connection String bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Config güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}