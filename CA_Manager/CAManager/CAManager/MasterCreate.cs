using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CAManager
{
    public partial class MasterCreate : Form
    {
        List<UsbDisk> disks;
        UsbDisk currentDisk;
        public MasterCreate()
        {
            InitializeComponent();
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
            bool allOk = true;
            Cryptography.sCertData data;
            data.dStart = dateStart.Value;
            data.dStop = dateStop.Value;
            data.fioOwner = tbxFIO.Text.Trim();
            data.login = tbxLogin.Text.Trim();
            string domainName = tbxDomain.Text.Trim();
            if (allOk)
            {
                idClient = Model.MasterCreateCertificate(data, domainName, currentDisk);
            }
            if (cmbGroup.SelectedValue != null)
                Model.SetProfileForClient(idClient, (int)cmbGroup.SelectedValue);
            if ((allOk) && (idClient != 0))
            {
                ControlClientProfile controlForm = new ControlClientProfile();
                controlForm.ChangeUser(idClient, tbxFIO.Text.Trim());
                controlForm.Show();
                Close();
            }
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myFWDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.myFWDataSet.Group);

        }
    }
}
