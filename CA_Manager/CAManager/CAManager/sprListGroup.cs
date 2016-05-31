using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class sprListGroup : Form
    {
        public sprListGroup()
        {
            InitializeComponent();
        }

        private void sprListGroup_Load(object sender, EventArgs e)
        {
            groupTableAdapter.Fill(myFWDataSet.Group);
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sprGroup group = new sprGroup((int)dgvGroups.SelectedRows[0].Cells[0].Value);
            group.Show();
        }

        private void mAdd_Click(object sender, EventArgs e)
        {
            sprGroup group = new sprGroup();
            group.Show();
        }

        private void mDel_Click(object sender, EventArgs e)
        {
            myFWDataSetTableAdapters.GroupProfileTableAdapter taP = new myFWDataSetTableAdapters.GroupProfileTableAdapter();
            taP.myDelete((int)dgvGroups.SelectedRows[0].Cells[0].Value);
            myFWDataSetTableAdapters.GroupTableAdapter taG = new myFWDataSetTableAdapters.GroupTableAdapter();
            taG.myDelete((int)dgvGroups.SelectedRows[0].Cells[0].Value);
        }
    }
}
