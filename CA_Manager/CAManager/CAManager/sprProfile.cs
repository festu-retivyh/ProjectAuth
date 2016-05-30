using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class sprProfile : Form
    {
        int curId;
        public sprProfile()
        {
            InitializeComponent();
            curId = 0;
        }
        public sprProfile(int id)
        {
            InitializeComponent();
            curId = id;
        }

        private void sprProfile_Load(object sender, EventArgs e)
        {
            this.program1TableAdapter.Fill(this.myFWDataSet.Program1);
            this.serverTableAdapter.Fill(this.myFWDataSet.Server);
            if (curId == 0)
                return;
            myFWDataSetTableAdapters.ProfileTableAdapter ta = new myFWDataSetTableAdapters.ProfileTableAdapter();
            var data = ta.GetProfileForId(curId);
            cbxServer.SelectedValue = (int)data.Rows[0].ItemArray[2];
            cbxProgram.SelectedValue = (int)data.Rows[0].ItemArray[1];
            tbxName.Text = data.Rows[0].ItemArray[3].ToString();
        }
    }
}
