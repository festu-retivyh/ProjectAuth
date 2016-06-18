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
            LoadAllPrograms();
            Model.UpdateViewTables += Model_UpdateViewTables;
        }

        private void LoadAllPrograms()
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
            OpenSprServer();
        }

        private void mDel_Click(object sender, EventArgs e)
        {
            myFWDataSetTableAdapters.ProgramTableAdapter ta = new myFWDataSetTableAdapters.ProgramTableAdapter();
            ta.myDelete((int)dgvProg.SelectedRows[0].Cells[0].Value);
        }
        private void OpenSprServer()
        {
            try
            {
                sprProgram spr = new sprProgram((int)dgvProg.SelectedRows[0].Cells[0].Value);
                
                spr.Show();
            }
            catch
            { }
        }

        private void Model_UpdateViewTables(object sender, EventArgs e)
        {
            LoadAllPrograms();
        }

        private void dgvProg_DoubleClick(object sender, EventArgs e)
        {
            OpenSprServer();
        }
    }
}
