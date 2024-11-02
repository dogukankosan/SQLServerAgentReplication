using System;
using System.IO;
using System.Reflection;

namespace AsyenUI.Classes
{
    internal static class TextLog
    {
        internal static void TextLogging(string message)
        {
            try
            {
                string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string logFilePath = Path.Combine(appDirectory, "log.txt");
                Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));
                File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}\n");
                _ = MailSender.MailSendForm(message);
            }
            catch (Exception)
            {

            }
        }
    }
}