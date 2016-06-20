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
    public partial class MasterAddServer : Form
    {
        List<UsbDisk> disks;
        UsbDisk currentDisk;
        public MasterAddServer()
        {
            InitializeComponent();
            disks = UsbSearcher.Search();
            cbxDisks.Items.Clear();
            for (int i = 0; i < disks.Count; i++)
            {
                cbxDisks.Items.Add(disks[i].name + "\\");
            }
        }

        private void cbxDisks_Click(object sender, EventArgs e)
        {
            List<UsbDisk> tempDisks = UsbSearcher.Search();
            cbxDisks.Items.Clear();
            for (int i = 0; i < disks.Count; i++)
            {
                cbxDisks.Items.Add(disks[i].name + "\\");
            }
            disks = tempDisks;
        }

        private void cbxDisks_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDisk = disks[cbxDisks.SelectedIndex];
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            int idServer = 0;
            sSERVER server = new sSERVER();
            server.address = tbxAddress.Text;
            server.name = tbxName.Text;
            server.dateStart = dateStart.Value;
            server.dateStop = dateStop.Value;

            idServer = Model.MasterAddServer(server, currentDisk);
            if (idServer != 0)
            {
                Model.CallEventUpdateViewTables();
                Close();
            }
            else
                MessageBox.Show("Some Error. ups..");
        }
    }
}
