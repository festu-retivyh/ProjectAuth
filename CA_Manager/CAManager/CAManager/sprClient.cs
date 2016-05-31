using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class sprClient : Form
    {
        private sCLIENT_INFO_FULL sClientInfo;
        
        public sprClient(sCLIENT_INFO_FULL sClientInfo)
        {
            InitializeComponent();
            this.sClientInfo = sClientInfo;
        }

        private void sprClient_Load(object sender, EventArgs e)
        {
            tbxLogin.Text = sClientInfo.login;
            tbxDomain.Text = sClientInfo.domain;
            tbxFName.Text = sClientInfo.f;
            tbxName.Text = sClientInfo.i;
            tbxSName.Text = sClientInfo.o;
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            myFWDataSetTableAdapters.UserTableAdapter ta = new myFWDataSetTableAdapters.UserTableAdapter();
            ta.myUpdate(tbxFName.Text, tbxName.Text, tbxSName.Text, tbxLogin.Text, tbxDomain.Text, sClientInfo.deleted, sClientInfo.clientId);
            Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
