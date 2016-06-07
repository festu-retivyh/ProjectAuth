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
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            AddLog("start");
            Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ProjectAuth");
            string server = myRegKey.GetValue("NameServer").ToString();
            myRegKey = myRegKey.OpenSubKey("secure");
            string login = myRegKey.GetValue("Login").ToString();
            string pass = myRegKey.GetValue("Password").ToString(); 
            myRegKey.Close();
            host = new ServiceHost(typeof(CA.CA));
            host.Open(); //Запуск SWF
            try
            {
                File.WriteAllText(@"D:\Service1.txt", server + login + pass);
            }
            catch { }
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
