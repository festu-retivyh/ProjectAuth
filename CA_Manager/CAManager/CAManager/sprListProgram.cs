using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class sprListProgram : Form
    {
        public sprListProgram()
        {
            InitializeComponent();
        }

        private void sprListProgram_Load(object sender, EventArgs e)
        {
            programTableAdapter.Fill(myFWDataSet.Program);

        }

        private void mAdd_Click(object sender, EventArgs e)
        {
            sprProgram spr = new sprProgram();
            spr.Show();
        }

        private void mSel_Click(object sender, EventArgs e)
        {
            try
            {
                sprProgram spr = new sprProgram((int)dgvProg.SelectedRows[0].Cells[0].Value);
                spr.Show();
            }
            catch
            { }
        }

        private void mDel_Click(object sender, EventArgs e)
        {
            myFWDataSetTableAdapters.ProgramTableAdapter ta = new myFWDataSetTableAdapters.ProgramTableAdapter();
            ta.myDelete((int)dgvProg.SelectedRows[0].Cells[0].Value);
        }
    }
}
