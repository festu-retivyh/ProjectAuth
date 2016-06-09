using System.ServiceModel;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        ServiceHost host;
        public Form1()
        {
            //InstallerClass ic = new InstallerClass();
            //ic.RegistrateServer();
            InitializeComponent();
            //if (!Model.CheckServerData())
            //    Close();
            host = new ServiceHost(typeof(Server.Srv));
            host.Open();
            //Model.SendMessageForJoinCA();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            host.Close();
        }
    }
}
