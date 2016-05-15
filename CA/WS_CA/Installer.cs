using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
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
            //string path = Path.Combine(new DirectoryInfo(Context.Parameters["assemblypath"].ToString()).Parent.FullName, "[project name].exe");
            
            base.Install(stateSaver);
            File.WriteAllText(@"D:\qwe.txt", Context.Parameters["dbname"]);

            AddDBTable(this.Context.Parameters["dbname"]);
        }

        SqlConnection sqlConnection = new SqlConnection();
        
        private void ExecuteSql(string dbName, string sql)
        {
            sqlConnection.ConnectionString = "Data Source=MACHINE;Integrated Security=true;";// User Id=adm;Password = Jhjk1209;";
            SqlCommand command = new SqlCommand(File.ReadAllText(sql), sqlConnection);

            //sqlConnection.ConnectionString = Properties.Settings.Default.masterConnectionString;
            command.Connection.Open();
            command.Connection.ChangeDatabase(dbName);
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public void CreateDatabase(string connString, string dbName, bool dropExisting)
        {
            SqlConnection cnn = new SqlConnection(connString);
            try
            {
                SqlCommand cmdCreate = new SqlCommand(string.Format("CREATE DATABASE [{0}]", dbName), cnn);
                cnn.Open();
                if (dropExisting)
                {
                    SqlCommand cmdDrop = new SqlCommand(string.Format("IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'{0}') DROP DATABASE [{0}]", dbName), cnn);
                    cmdDrop.ExecuteNonQuery();
                }
                cmdCreate.ExecuteNonQuery();
            }
            finally
            {
                cnn.Close();
            }
        }


        protected void AddDBTable(string dbName)
        {
            try
            {
                CreateDatabase("server=MACHINE;Integrated Security=true;", "ProjectAuth_DB", true);
                //ExecuteSql("master", "USE [master] CREATE DATABASE[ProjectAuth_DB] ");

                ExecuteSql("ProjectAuth_DB", @"D:\db.sql");
            }
            catch (Exception e)
            {
                MessageBox.Show("In exception handler: " + e.Message);
                throw;
            }
        }
    }
}
