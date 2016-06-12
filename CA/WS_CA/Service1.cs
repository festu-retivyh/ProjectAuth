using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceProcess;
using System.Text;
using System.IO;
using System.Data.SqlClient;

namespace WS_CA
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost host;
        CA.EventTimer et;
        private string server="", login="", pass="";
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            AddLog("start");
            try
            {
                Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ProjectAuth", true);
                server = myRegKey.GetValue("NameServer").ToString();
                myRegKey = myRegKey.OpenSubKey("secure", true);
                login = myRegKey.GetValue("Login").ToString();
                pass = myRegKey.GetValue("Password").ToString();
                myRegKey.Close();
                File.WriteAllText(@"D:\Service1inTRY.txt", server + login + pass);
            }
            catch { }
            host = new ServiceHost(typeof(CA.CA));
            host.Open(); //Запуск SWF
            try { if (pass == "")
                {
                    string [] str = File.ReadAllLines(@"C:\ProgramData\ProjectAuth\data.txt");

                    server = str[0];
                    login = str[1];
                    pass = str[2];
                } }
            catch { }
            try
            {
                File.WriteAllText(@"D:\Service1.txt", server + login + pass);
            }
            catch
            {}
            et = new CA.EventTimer();
            et.SetParams(server, login, pass);
            et.Start();
        }

        protected override void OnStop()
        {
            et.Stop();
            host.Close();
            AddLog("stop");
        }

        public void AddLog(string log)
        {
            try
            {
                if (!EventLog.SourceExists("MyExampleService"))
                {
                    EventLog.CreateEventSource("MyExampleService", "MyExampleService");
                }
                eventLog1.Source = "MyExampleService";
                eventLog1.WriteEntry(log);
            }
            catch { }
        }
    }
}
