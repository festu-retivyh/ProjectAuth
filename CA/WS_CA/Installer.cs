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
            ExecuteSqlScript(Context.Parameters["dbname"].ToString(), "CREATE LOGIN "+ Context.Parameters["dbuser"] + " WITH PASSWORD = '" + Context.Parameters["dbpass"] + "';ALTER SERVER ROLE [sysadmin] ADD MEMBER " + Context.Parameters["dbuser"]);
            File.Delete(Context.Parameters["targetdir"] + "db.sql");

            string key = Cryptography.Cryptography.GeneratePrivateKey();
            key = Cryptography.Cryptography.EncryptAes(key, Context.Parameters["dbpass"], Context.Parameters["dbuser"]);

            ExecuteSqlScript(Context.Parameters["dbname"].ToString(), "USE [ProjectAuth_DB] INSERT INTO [dbo].[Parametrs] ([property],[value]) VALUES ('privateKey','" + key + "') ");


            Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ProjectAuth");
            myRegKey.SetValue("NameServer", Context.Parameters["dbname"].ToString(), Microsoft.Win32.RegistryValueKind.String);
            var mySec = myRegKey.CreateSubKey("secure");
            mySec.SetValue("Login", Context.Parameters["dbuser"].ToString(), Microsoft.Win32.RegistryValueKind.String);
            mySec.SetValue("Password", Context.Parameters["dbpass"].ToString(), Microsoft.Win32.RegistryValueKind.String);
            mySec.Close();
            myRegKey.Close();
            
            

        }

        static void ExecuteSqlScript(string srvName, string script, bool stock = true)
        {
             
            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);
            SqlConnection myConn;
            if (stock)
                myConn = new SqlConnection("Server="+srvName+ ";Integrated security=SSPI");
            else
                myConn = new SqlConnection(srvName);
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
            catch { File.WriteAllText(@"D:\CAinstaller_Error.txt", script); }
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
                try
                {
                    Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ProjectAuth");
                    string DBServer = myRegKey.GetValue("NameServer").ToString();
                    myRegKey = myRegKey.OpenSubKey("secure");
                    string DBUser = myRegKey.GetValue("login").ToString();
                    string DBPass = myRegKey.GetValue("password").ToString();
                    myRegKey.Close();
                    string connection = "Data Source=" + DBServer + ";Initial Catalog=ProjectAuth_DB;Integrated security=False;User Id=" + DBUser + ";Password = " + DBPass + ";";
                    SqlConnection conn = new SqlConnection(connection);
                    try
                    {
                        conn.Open();
                    }
                    catch
                    { return; }
                    string comm = @"alter database [ProjectAuth_DB] set single_user with rollback immediate         DROP DATABASE [ProjectAuth_DB]";
                    SqlCommand cmd = new SqlCommand(comm, conn);
                    cmd.ExecuteNonQuery();

                }
                catch { }
                //ExecuteSqlScript(myRegKey.GetValue("NameServer").ToString(), "DROP DATABASE [ProjectAuth_DB]");
                //myRegKey.Close();
            }
        }
    }
}
