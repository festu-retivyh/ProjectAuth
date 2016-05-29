using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class sprGroup : Form
    {
        private int id;
        private string name;
        public sprGroup(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void sprGroup_Load(object sender, EventArgs e)
        {
            profileTableAdapter.Fill(myFWDataSet.Profile);
            if (id == 0)
                return;
            ChecksProfileForCurGroup();
            string name = DbConnector.getGroupName(id);
            tbxName.Text = name;
        }

        private void ChecksProfileForCurGroup()
        {
            int[] profiles = DbConnector.GetProfileForGroup(id);
            foreach (int prof in profiles)
            {
                foreach (DataGridViewRow row in dgvProfile.Rows)
                {
                    if (prof == (int)row.Cells[0].Value)
                        row.Cells[1].Value = true;
                }
            }
        }

        private void mSaveExit_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                int _id = DbConnector.AddGroup(tbxName.Text);
                id = _id;
            }
            else if(name!=tbxName.Text)
                DbConnector.SetNameGroup(id, tbxName.Text, name);
            DbConnector.ClearGroupProfile(id);
            int[] masProf = new int[0];
            foreach (DataGridViewRow row in dgvProfile.Rows)
            {
                if (row.Cells[1].Value == null)
                    continue;
                if ((bool)row.Cells[1].Value)
                {
                    Array.Resize(ref masProf, masProf.Length + 1);
                    masProf[masProf.Length - 1] = (int)row.Cells[0].Value;
                }
            }
            DbConnector.SetProfilesForGroup(id, masProf);
            Close();
        }

        private void mClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
