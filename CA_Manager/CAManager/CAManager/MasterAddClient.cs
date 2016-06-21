using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CAManager
{
    public partial class MasterAddClient : Form
    {
        List<UsbDisk> disks;
        UsbDisk currentDisk;
        int curId = 0;
        public MasterAddClient()
        {
            InitializeComponent();
            disks = UsbSearcher.Search();
            cbxDisks.Items.Clear();
            for (int i = 0; i < disks.Count; i++)
            {
                cbxDisks.Items.Add(disks[i].name + "\\");
            }
        }
        public MasterAddClient(int id, string name, string domain, string login)
        {
            InitializeComponent();
            curId = id;
            tbxDomain.Text = domain;
            tbxFIO.Text = name;
            tbxLogin.Text = login;
            tbxLogin.Enabled = false;
            tbxFIO.Enabled = false;
            tbxDomain.Enabled = false;
            cmbGroup.Visible = false;
            disks = UsbSearcher.Search();
            cbxDisks.Items.Clear();
            for (int i = 0; i < disks.Count; i++)
            {
                cbxDisks.Items.Add(disks[i].name + "\\");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
                int idClient = 0;
            if (curId == 0)
            {
                bool allOk = true;
                Cryptography.sCertData data;
                data.dStart = dateStart.Value;
                data.dStop = dateStop.Value;
                data.fioOwner = tbxFIO.Text.Trim();
                data.login = tbxLogin.Text.Trim();
                string domainName = tbxDomain.Text.Trim();
                if (currentDisk == null)
                    allOk = false;
                if (!allOk)
                {
                    return;
                }
                idClient = Model.MasterCreateCertificate(data, domainName, currentDisk);
                if (cmbGroup.SelectedValue != null)
                    Model.SetProfileForClient(idClient, (int)cmbGroup.SelectedValue);
                if ((allOk) && (idClient != 0))
                {
                    ControlClientProfile controlForm = new ControlClientProfile();
                    controlForm.ChangeUser(idClient, tbxFIO.Text.Trim(), cmbGroup.SelectedValue == null ? 0 : (int)cmbGroup.SelectedValue);
                    controlForm.Show();
                    Close();
                }
            }
            else
            {
                bool allOk = true;
                Cryptography.sCertData data;
                data.dStart = dateStart.Value;
                data.dStop = dateStop.Value;
                data.fioOwner = tbxFIO.Text.Trim();
                data.login = tbxLogin.Text.Trim();
                string domainName = tbxDomain.Text.Trim();
                if (currentDisk == null)
                    allOk = false;
                if (!allOk)
                {
                    return;
                }
                idClient = Model.MasterCreateCertificate(data, domainName, currentDisk, false);
            }
            Model.CallEventUpdateViewTables();
        }

        private void comboBox1_Click(object sender, EventArgs e)
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

        private void MasterCreate_Load(object sender, EventArgs e)
        {
            this.groupTableAdapter.Fill(this.myFWDataSet.Group);

        }
    }
}
