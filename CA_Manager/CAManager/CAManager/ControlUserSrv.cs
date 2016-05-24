using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class ControlUserSrv : Form
    {
        int currentClientId;
        public ControlUserSrv(int id=0)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myFWDataSet1.Program". При необходимости она может быть перемещена или удалена.
            //this.programTableAdapter.Fill(this.myFWDataSet.Program);
            tbxUser.Text = currentClientId.ToString();
            userSrvTableAdapter.Fill(myFWDataSet.UserSrv, currentClientId);
            programTableAdapter.Fill(myFWDataSet.Program, currentClientId);//, currentClientId);
            //dgvProgram.DataBindings.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DbConnector.ClearUsrSrv(currentClientId);
            foreach (DataGridViewRow a in dgvUserSrv.Rows)
            {
                if (a.Cells[0].Value == null)
                    continue;
                if ((bool)a.Cells[0].Value)
                {
                    foreach (DataGridViewRow p in dgvProgram.Rows)
                    {
                        if (p.Cells[0].Value == null)
                            continue;
                        if ((bool)p.Cells[0].Value)
                        {
                            DbConnector.AddUsrSrv(currentClientId, (int)a.Cells[2].Value, (int)p.Cells[2].Value);
                        }
                    }
                }
            }
            Close();
        }
        

        //private void fillForCLientToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        programTableAdapter.FillForClient(myFWDataSet1.Program, currentClientId);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
