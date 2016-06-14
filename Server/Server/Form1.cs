using System.IO;
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
            if (!Model.CheckServerData())
                Close();
            CmdProxy cmd = new CmdProxy();
            cmd.Execute("add rule name=ProjectAuth_Server protocol=TCP localport=46000-46001 dir=in action=allow remoteip=" + Model.DecryptServerData()[3]);
            host = new ServiceHost(typeof(Server.Srv));
            host.Open();
            Model.SendMessageForJoinCA();
            ControlFW.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlFW.Stop();
            CmdProxy cmd = new CmdProxy();
            cmd.ExecuteAdv("reset");
            host.Close();
        }
    }
}
