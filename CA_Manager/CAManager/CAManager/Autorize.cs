using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAManager
{
    public partial class Autorize : Form
    {
        string srv="", usr="", pss="", server;

        private void tbnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string connStr, p, u;
        public Autorize()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\ProjectAuth");
                server = myRegKey.GetValue("NameServer").ToString();
                myRegKey.Close();
            }
            catch { }
            if (server != null)
                srv = server;
            if (srv != "")
                tbxSrv.Text = srv;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            srv = tbxSrv.Text;
            usr = tbxLogin.Text;
            pss = tbxPassword.Text;
            tbxPassword.Text = "";
            var connection = "Data Source=" + srv + ";Initial Catalog=ProjectAuth_DB;Integrated security=False;User Id=" + usr + ";Password = " + pss + ";";
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                if (server == null)
                {
                    Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ProjectAuth");
                    myRegKey.SetValue("NameServer", srv);
                }
                else if (server != srv)
                {
                    Microsoft.Win32.RegistryKey myRegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ProjectAuth");
                    myRegKey.SetValue("NameServer", srv);
                }
                connStr = connection;
                p = pss;
                u = usr;
                Close();
            }
            catch
            {
                conn = null;
                pss = "";
                usr = "";
                srv = "";
                MessageBox.Show("Ошибка подключения к программе ProjectAuth","Ошибка аутентификации");
            }
        }
    }
}
