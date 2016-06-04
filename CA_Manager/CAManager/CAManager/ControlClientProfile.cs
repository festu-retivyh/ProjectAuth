using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class ControlClientProfile : Form
    {
        int currentClientId;
        int currentGroupId;
        public ControlClientProfile(int clientId = 0, int groupId = 0)
        {

            currentClientId = clientId;
            currentGroupId = groupId;
            InitializeComponent();

            groupTableAdapter.Fill(myFWDataSet.Group);
            profileTableAdapter1.Fill(myFWDataSet.Profile);
        }

        public void ChangeUser(int clientId, string name, int groupId = 0)
        {
            currentClientId = clientId;
            currentGroupId = groupId;
            cbxGroup.SelectedValue = groupId;
            tbxUser.Text = name;
            UpdateChecksProfile();
        }

        private void UpdateChecksProfile()
        {
            ClearChecksInDgv();
            if (currentGroupId == 0)
            {
                myFWDataSetTableAdapters.ClientProfileTableAdapter ta = new myFWDataSetTableAdapters.ClientProfileTableAdapter();
                var dt = ta.GetDataForClientId(currentClientId);
                foreach (myFWDataSet.ClientProfileRow row in dt.Rows)
                {
                    foreach (DataGridViewRow str in dataGridView1.Rows)
                    {
                        if (row.profileId == (int)str.Cells[0].Value)
                            str.Cells[1].Value = true;
                    }
                }
            }
            else
            {
                myFWDataSetTableAdapters.GroupProfileTableAdapter taProfile = new myFWDataSetTableAdapters.GroupProfileTableAdapter();
                var dtProfile = taProfile.GetDataForGroup(currentGroupId);
                foreach (myFWDataSet.GroupProfileRow row in dtProfile.Rows)
                {
                    foreach (DataGridViewRow str in dataGridView1.Rows)
                    {
                        if (row.profileId == (int)str.Cells[0].Value)
                            str.Cells[1].Value = true;
                    }
                }
            }
        }

        private void ClearChecksInDgv()
        {
            foreach (DataGridViewRow str in dataGridView1.Rows)
            {
                str.Cells[1].Value = false;
            }
        }

        private void ControlUserSrv_Load(object sender, EventArgs e)
        {
            UpdateChecksProfile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DbConnector.ClearClientProfile(currentClientId);
            int[] masProf = new int[0];
            foreach (DataGridViewRow str in dataGridView1.Rows)
            {
                if ((bool)str.Cells[1].Value)
                {
                    Array.Resize(ref masProf, masProf.Length + 1);
                    masProf[masProf.Length - 1] = (int)str.Cells[0].Value;
                }
            }
            DbConnector.SetProfilesForClient(currentClientId, masProf);
            Close();
        }

        private void cbxGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedValue == null)
                return;
            currentGroupId = (int)cbxGroup.SelectedValue;
            UpdateChecksProfile();
        }
    }
}
