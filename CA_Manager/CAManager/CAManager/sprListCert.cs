﻿using System;
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
