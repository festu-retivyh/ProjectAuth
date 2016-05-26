using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class ControlClientProfile : Form
    {
        int currentClientId;
        public ControlClientProfile(int id=0)
        {
            currentClientId = id;
            InitializeComponent();

        }
        public void ChangeUser(int id, string name)
        {
            tbxUser.Text = name;
            UpdateChecksProfile();
        }
        private void UpdateChecksProfile()
        {
            foreach (DataGridViewRow str in dataGridView1.Rows)
            {
                str.Cells[1].Value = false;
            }
            myFWDataSetTableAdapters.GetClientProfilesTableAdapter ta = new myFWDataSetTableAdapters.GetClientProfilesTableAdapter();
            var dt = ta.GetData(currentClientId);
            foreach (myFWDataSet.GetClientProfilesRow row in dt.Rows)
            {
                foreach (DataGridViewRow str in dataGridView1.Rows)
                {
                    if (row.profileId == (int)str.Cells[0].Value)
                        str.Cells[1].Value = true;
                }
            }
        }

        private void ControlUserSrv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myFWDataSet1.Profile". При необходимости она может быть перемещена или удалена.
            this.profileTableAdapter1.Fill(this.myFWDataSet1.Profile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myFWDataSet1.Profile". При необходимости она может быть перемещена или удалена.
            profileTableAdapter.Fill(myFWDataSet.Profile);

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
        
    }
}
