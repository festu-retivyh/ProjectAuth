using CA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WS_CA
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();
        }
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            ExecuteSqlScript(Context.Parameters["dbname"].ToString(), File.ReadAllText(Context.Parameters["targetdir"] + "db.sql"));
            File.Delete(Context.Parameters["targetdir"] + "db.sql");

            Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ProjectAuth");
            myRegKey.SetValue("NameServer", Context.Parameters["dbname"]);
            myRegKey.Close();

            //CASettings.Default.Setting = Context.Parameters["dbname"];
            //CASettings.Default.Save();
            //File.WriteAllText(@"d:\sett.txt", CASettings.Default.Setting);
            //CA.ConfigurateSattings.setMainSettings(Context.Parameters["dbname"]);
        }

        static void ExecuteSqlScript(string srvName, string script)
        {
             
            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);
            SqlConnection myConn = new SqlConnection("Server="+srvName+ ";Integrated security=SSPI");
            myConn.Open();
            try
            {
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        using (var command = new SqlCommand(commandString, myConn))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch {  }
            finally
            {
                myConn.Close();
            }

        }
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
            string message = "Требуется ли безвозвратно удалить базу данных?"; 
            var result = MessageBox.Show(message, "Удалить базу данных",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ProjectAuth");
                ExecuteSqlScript(myRegKey.GetValue("NameServer").ToString(), "DROP DATABASE [ProjectAuth_DB]");
                myRegKey.Close();
            }
        }


    }
}
