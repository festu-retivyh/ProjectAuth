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
    public partial class sprListGroup : Form
    {
        public sprListGroup()
        {
            InitializeComponent();
        }

        private void sprListGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myFWDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.myFWDataSet.Group);

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
