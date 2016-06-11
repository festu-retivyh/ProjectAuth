using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace WS_CA
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {
            new ServiceController(serviceInstaller1.ServiceName).Start();
        }

        private void serviceInstaller1_BeforeUninstall(object sender, InstallEventArgs e)
        {
            try
            {
                if (new ServiceController(serviceInstaller1.ServiceName).Status == ServiceControllerStatus.Running)
                    new ServiceController(serviceInstaller1.ServiceName).Stop();
            }
            catch { }
        }

    }
}
