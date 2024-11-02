using AsyenUI.Classes;
using System;
using System.Data;
using System.Globalization;
using System.ServiceProcess;
using System.Timers;

namespace AsyenService
{
    public partial class Service1 : ServiceBase
    {
        private Timer timers;
        public Service1()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            if (timers == null)
            {
                timers = new Timer();
            }
            timers.Interval = 60_000;
            timers.Elapsed += OnElapsedTime;
            timers.Start();
        }
        protected override void OnStop()
        {
            timers?.Stop();
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            SQLCommadStart();
        }
        public void SQLCommadStart()
        {
            string currentDay = DateTime.Now.ToString("dddd", new CultureInfo("tr-TR"));
            string currentTime = DateTime.Now.ToString("HH:mm");
            timers.Stop();
            try
            {
                DataTable dt = SQLLiteCRUD.GetDataFromSQLite("SELECT * FROM SQLQuerys");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][3].ToString() == "1")
                    {
                        string[] days = dt.Rows[i][6].ToString().Split(',');
                        string startHour = dt.Rows[i][4].ToString().Substring(0, 5);
                        string lastHour = dt.Rows[i][7] is null || dt.Rows[i][7] == "" ? "" : dt.Rows[i][7].ToString().Substring(0, 5);
                        for (byte j = 0; j < days.Length; j++)
                        {
                            if (days[j] == currentDay && ((startHour == currentTime) || (lastHour == currentTime)))
                            {
                                _ = SQLCRUD.InserUpdateDelete(dt.Rows[i][2].ToString());
                                if (string.IsNullOrEmpty(lastHour))
                                {
                                    TimeSpan t = TimeSpan.Parse(startHour);
                                    t = t.Add(new TimeSpan(int.Parse(dt.Rows[i][5].ToString()), 0, 0));
                                    t = TimeSpan.Parse(t.ToString().Replace("1.", "").Replace("2.", ""));
                                    _ = SQLLiteCRUD.InserUpdateDelete("UPDATE SQLQuerys SET LastStepDate='" + t + "' WHERE ID=" + dt.Rows[i][0].ToString() + "");
                                }
                                else
                                {
                                    TimeSpan t = TimeSpan.Parse(lastHour);
                                    t = t.Add(new TimeSpan(int.Parse(dt.Rows[i][5].ToString()), 0, 0));
                                    t = TimeSpan.Parse(t.ToString().Replace("1.", "").Replace("2.", ""));
                                    _ = SQLLiteCRUD.InserUpdateDelete("UPDATE SQLQuerys SET LastStepDate='" + t + "' WHERE ID=" + dt.Rows[i][0].ToString() + "");
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextLog.TextLogging(ex.Message);
            }
            timers.Start();
        }
    }
}