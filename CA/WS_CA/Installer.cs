﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
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
            try
            {
                var proc = new Process();
                proc.StartInfo.FileName = "netsh.exe";
                proc.StartInfo.Arguments = " advfirewall firewall add rule name=ProjectAuth_CA protocol=TCP localport=45000-45001 dir=in action=allow";
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
                proc.WaitForExit();
            }
            catch
            {
                throw new Exception("Не достаточно прав для управления брандмауэром, установка не может быть продолжена");
            }
            base.Install(stateSaver);
            try
            {
                try
                {
                    ExecuteSqlScript(Context.Parameters["dbname"].ToString(), File.ReadAllText(Context.Parameters["targetdir"] + "db.sql"));
                }
                catch { MessageBox.Show("База данных не была развернута, вероятно она уже существовала"); }
                ExecuteSqlScript(Context.Parameters["dbname"].ToString(), "IF NOT EXISTS (SELECT name FROM master.sys.server_principals WHERE name = '" + Context.Parameters["dbuser"] + "') " +
                   " BEGIN CREATE LOGIN " + Context.Parameters["dbuser"] + " WITH PASSWORD = '" + Context.Parameters["dbpass"] + "';ALTER SERVER ROLE [sysadmin] ADD MEMBER " + Context.Parameters["dbuser"] + " END " +
                   " ELSE BEGIN ALTER LOGIN " + Context.Parameters["dbuser"] + " WITH PASSWORD = '" + Context.Parameters["dbpass"] + "' END");
                File.Delete(Context.Parameters["targetdir"] + "db.sql");

                string key = Cryptography.Cryptography.GeneratePrivateKey();
                key = Cryptography.Cryptography.EncryptAes(key, Context.Parameters["dbpass"], Context.Parameters["dbuser"]);

                ExecuteSqlScript(Context.Parameters["dbname"].ToString(), "USE [ProjectAuth_DB] INSERT INTO [dbo].[Parametrs] ([property],[value]) VALUES ('privateKey','" + key + "') ");

                var ips = GetLocalIPAddress();
                bool loop = true;
                while (loop)
                {
                    if (ips.Count == 1)
                    {
                        ExecuteSqlScript(Context.Parameters["dbname"].ToString(), "USE [ProjectAuth_DB] INSERT INTO [dbo].[Parametrs] ([property],[value]) VALUES ('AddressService','" + ips[0] + "') ");
                        loop = false;
                    }
                    else
                    {
                        try
                        {
                            var rezult = MessageBox.Show("Желаете использовать ip-адрес: " + ips[0] + ", для работы ProjectAuth", "Используем этот адрес?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (rezult == DialogResult.Yes)
                            {
                                ExecuteSqlScript(Context.Parameters["dbname"].ToString(), "USE [ProjectAuth_DB] INSERT INTO [dbo].[Parametrs] ([property],[value]) VALUES ('AddressService','" + ips[0] + "') ");
                                loop = false;
                            }
                            else
                            {
                                ips.Remove(ips[0]);
                            }
                        }
                        catch
                        {
                            loop = false;
                            throw new Exception("Не найден ip адрес через который мог бы работать Центр сертификации и аутентификации");
                        }
                    }
                }
                try
                {
                    Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\ProjectAuth");
                    myRegKey.SetValue("NameServer", Context.Parameters["dbname"].ToString(), Microsoft.Win32.RegistryValueKind.String);
                    var mySec = myRegKey.CreateSubKey("secure");
                    mySec.SetValue("Login", Context.Parameters["dbuser"].ToString(), Microsoft.Win32.RegistryValueKind.String);
                    mySec.SetValue("Password", Context.Parameters["dbpass"].ToString(), Microsoft.Win32.RegistryValueKind.String);
                    
                    mySec.Close();
                    myRegKey.Close();
                }
                catch { }
            }
            catch { }
        }
        private static List<string> GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            List<string> ips = new List<string>();
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ips.Add(ip.ToString());
                }
            }
            if(ips.Count==0)
                throw new Exception("Не найден ip адрес через который мог бы работать Центр сертификации и аутентификации");
            return ips;
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
        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }
    }
    
}
