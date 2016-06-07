using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class sprListCert : Form
    {
        public sprListCert()
        {
            InitializeComponent();
        }

        private void sprListCert_Load(object sender, EventArgs e)
        {
            myCertificateTableAdapter.Fill(myFWDataSet.myCertificate);
            certificateTableAdapter.Fill(myFWDataSet.Certificate);
        }

        private void mAddServer_Click(object sender, EventArgs e)
        {
            MasterAddServer add = new MasterAddServer();
            add.ShowDialog();
        }

        private void mAddClient_Click(object sender, EventArgs e)
        {
            MasterAddClient add = new MasterAddClient();
            add.ShowDialog();
        }

        private void mSel_Click(object sender, EventArgs e)
        {
            sprCert cert = new sprCert((int)dataGridView1.SelectedRows[0].Cells[0].Value);
            cert.Show();
        }
    }
}
