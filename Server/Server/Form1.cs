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
            host = new ServiceHost(typeof(Server.Srv));
            host.Open();
            //try
            //{
                Model.SendMessageForJoinCA();
            //}
            //catch
            //{
            //    File.WriteAllText(@"D:\sendMessageJoinSrv.txt", host.State.ToString());
            //}
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            host.Close();
        }
    }
}
