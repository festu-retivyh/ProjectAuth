using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class sprClient : Form
    {
        private int curId;
        private bool del;
        public sprClient(int id)
        {
            InitializeComponent();
            curId = id;
        }

        private void sprClient_Load(object sender, EventArgs e)
        {
            myFWDataSetTableAdapters.ClientInfoTableAdapter tbClientInfo = new myFWDataSetTableAdapters.ClientInfoTableAdapter();
            var data = tbClientInfo.GetData(curId);
            if (data.Count != 0)
            {
                tbxFName.Text = data[0].FName;
                tbxName.Text = data[0].Name;
                tbxSName.Text = data[0].SName;
                tbxLogin.Text = data[0].Login;
                tbxDomain.Text = data[0].Domain;
                del = data[0].Deleted;
            }
            else
            {
                MessageBox.Show("Клиент не выбран", "Ошибка");
                Close();
            }
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            myFWDataSetTableAdapters.UserTableAdapter ta = new myFWDataSetTableAdapters.UserTableAdapter();
            ta.myUpdate(tbxFName.Text, tbxName.Text, tbxSName.Text, tbxLogin.Text, tbxDomain.Text, del, curId);
            Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выдатьНовыйСертификатToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
