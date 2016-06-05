using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace CAManager
{
    static class Program
    {
        public static string ConnectionSetting;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ProjectAuth");
            var connection = "Data Source=" + myRegKey.GetValue("NameServer") + ";Initial Catalog=ProjectAuth_DB;Integrated Security=False;User Id=adm;Password = Jhjk1209;";
            ConnectionSetting = connection;
            myRegKey.Close();

            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = System.IO.Path.Combine(appPath, "CAManager.exe.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings["CAManager.Properties.Settings.myFWConnectionString"].ConnectionString = connection;
            config.Save();

            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            //connectionStringsSection.ConnectionStrings["CAManager.Properties.Settings.myFWConnectionString"].ConnectionString = connection;
            //config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            
            //connectionStringsSection.ConnectionStrings["CAManager.Properties.Settings.myFWConnectionString"].ConnectionString = connection;
            //config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            Application.Run(new MainForm());
        }
        //private static void SetConnectionString()
        //{

        //    ConnectionStringSettings importToConnectionString = currentConfiguration.ConnectionStrings.ConnectionStrings[newName];

        //    if (importToConnectionString == null)
        //    {
        //        importToConnectionString = new ConnectionStringSettings();
        //        importToConnectionString.ConnectionString = importFromConnectionString.ConnectionString;
        //        importToConnectionString.ProviderName = importFromConnectionString.ProviderName;
        //        importToConnectionString.Name = newName;
        //        currentConfiguration.ConnectionStrings.ConnectionStrings.Add(importToConnectionString);
        //    }
        //    else
        //    {
        //        importToConnectionString.ConnectionString = importFromConnectionString.ConnectionString;
        //        importToConnectionString.ProviderName = importFromConnectionString.ProviderName;
        //    }

        //    Properties.Settings.Default.Reload();
        //}
    }
}
