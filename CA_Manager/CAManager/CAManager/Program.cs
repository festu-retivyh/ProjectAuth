using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace CAManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            Autorize auth = new Autorize();
            auth.ShowDialog();
            string connection = auth.connStr;
            if (connection == null)
                return;
            Model.setParams(auth.p, auth.u);
            auth = null;
            try
            {
                string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string configFile = System.IO.Path.Combine(appPath, "CAManager.exe.config");
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                configFileMap.ExeConfigFilename = configFile;
                System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            
            config.ConnectionStrings.ConnectionStrings["CAManager.Properties.Settings.myFWConnectionString"].ConnectionString = connection;
            config.Save();
            }
            catch { }
            ConfigurationManager.RefreshSection("connectionStrings");
            
            Application.Run(new MainForm());
        }
    }
}
