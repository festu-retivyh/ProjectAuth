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
            userSrvTableAdapter.Fill(myFWDataSet.UserSrv, id);
        }

        private void ControlUserSrv_Load(object sender, EventArgs e)
        {
            
            //myFWDataSetTableAdapters.ProfileTableAdapter prof = new myFWDataSetTableAdapters.ProfileTableAdapter();
            //var profTb = prof.GetData();
            //int i = 0;
            //foreach (var profile in profTb)
            //{
            //    i = dgvClientProf.Rows.Add();
            //    dgvClientProf.Rows[i].Cells[1].Value = profile.Name;
            //    dgvClientProf.Rows[i].Cells[2].Value = profile.id;
            //}
                
            //myFWDataSetTableAdapters.GetClientProfilesTableAdapter clientProfile = new myFWDataSetTableAdapters.GetClientProfilesTableAdapter();
            //var dt = clientProfile.GetData(currentClientId);
            //dgvClientProf.Rows.
            //foreach (DataGridViewRow p in dgvClientProf.Rows)
            //{
            //    try
            //    {
            //        if ((int)(p.Cells[3].Value) == 1)
            //        {
            //            p.Cells[4].Value = true;
            //        }
            //    }
            //    catch { }
            //}

            // TODO: данная строка кода позволяет загрузить данные в таблицу "myFWDataSet1.Program". При необходимости она может быть перемещена или удалена.
            //this.programTableAdapter.Fill(this.myFWDataSet.Program);
            //tbxUser.Text = currentClientId.ToString();
            //userSrvTableAdapter.Fill(myFWDataSet.UserSrv, currentClientId);
            //programTableAdapter.Fill(myFWDataSet.Program, currentClientId);//, currentClientId);
            //foreach (DataGridViewRow p in dataGridView1.Rows)
            //{
            //    try
            //    {
            //        if ((int)(p.Cells[3].Value) == 1)
            //        {
            //            p.Cells[4].Value = true;
            //        }
            //    }
            //    catch { }
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DbConnector.ClearUsrSrv(currentClientId);
            //foreach (DataGridViewRow a in dgvClientProf.Rows)
            //{
            //    if (a.Cells[0].Value == null)
            //        continue;
            //    if ((bool)a.Cells[0].Value)
            //    {
            //        foreach (DataGridViewRow p in dgvProgram.Rows)
            //        {
            //            if (p.Cells[0].Value == null)
            //                continue;
            //            if ((bool)p.Cells[0].Value)
            //            {
            //                DbConnector.AddUsrSrv(currentClientId, (int)a.Cells[2].Value, (int)p.Cells[2].Value);
            //            }
            //        }
            //    }
            //}
            //Close();
        }

        private void dgvUserSrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
