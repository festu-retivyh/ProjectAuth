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
            myFWDataSetTableAdapters.GroupTableAdapter ta = new myFWDataSetTableAdapters.GroupTableAdapter();
            ta.Delete((int)dgvGroups.SelectedRows[0].Cells[0].Value, (string)dgvGroups.SelectedRows[0].Cells[1].Value);
        }
    }
}
