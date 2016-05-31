using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myFWDataSet.myCertificate". При необходимости она может быть перемещена или удалена.
            this.myCertificateTableAdapter.Fill(this.myFWDataSet.myCertificate);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myFWDataSet.Certificate". При необходимости она может быть перемещена или удалена.
            this.certificateTableAdapter.Fill(this.myFWDataSet.Certificate);

        }

        private void mAddServer_Click(object sender, EventArgs e)
        {
            MasterAdd add = new MasterAdd();
            add.ShowDialog();
        }

        private void mAddClient_Click(object sender, EventArgs e)
        {
            MasterCreate add = new MasterCreate();
            add.ShowDialog();
        }

        private void mSel_Click(object sender, EventArgs e)
        {
            sprCert cert = new sprCert((int)dataGridView1.SelectedRows[0].Cells[0].Value);
            cert.Show();
        }
    }
}
