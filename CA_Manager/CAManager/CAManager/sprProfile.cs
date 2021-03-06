﻿using System;
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
            programTableAdapter.Fill(myFWDataSet.Program);
            serverTableAdapter.Fill(myFWDataSet.Server);
            if (curId == 0)
                return;
            myFWDataSetTableAdapters.ProfileTableAdapter ta = new myFWDataSetTableAdapters.ProfileTableAdapter();
            var data = ta.GetProfileForId(curId);
            cbxServer.SelectedValue = (int)data.Rows[0].ItemArray[2];
            cbxProgram.SelectedValue = (int)data.Rows[0].ItemArray[1];
            tbxName.Text = data.Rows[0].ItemArray[3].ToString();
        }

        private void mSaveExit_Click(object sender, EventArgs e)
        {
            if (curId == 0)
            {
                myFWDataSetTableAdapters.ProfileTableAdapter ta = new myFWDataSetTableAdapters.ProfileTableAdapter();
                ta.Insert((int)cbxProgram.SelectedValue, (int)cbxServer.SelectedValue, tbxName.Text);
            }
            else
            {
                myFWDataSetTableAdapters.ProfileTableAdapter ta = new myFWDataSetTableAdapters.ProfileTableAdapter();
                ta.myUpdate((int)cbxProgram.SelectedValue, (int)cbxServer.SelectedValue, tbxName.Text, curId);
            }
            Model.CallEventUpdateViewTables();
            Close();
        }

        private void mCopy_Click(object sender, EventArgs e)
        {
            curId = 0;
        }
    }
}
