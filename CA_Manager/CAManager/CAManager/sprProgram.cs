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
    public partial class sprProgram : Form
    {
        int curId;
        public delegate void ChangeInformation();
        public event ChangeInformation change;
        public sprProgram()
        {
            InitializeComponent();
            curId = 0;
        }
        public sprProgram(int id)
        {
            InitializeComponent();
            curId = id;
        }

        private void sprProgram_Load(object sender, EventArgs e)
        {
            if (curId == 0)
                return;
            myFWDataSetTableAdapters.ProgramTableAdapter ta = new CAManager.myFWDataSetTableAdapters.ProgramTableAdapter();
            var data = ta.GetDataForId(curId);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Не найдена выбранная программа", "Ошибка");
                Close();
            }
            tbxName.Text = data.Rows[0].ItemArray[1].ToString();
            tbxPort.Text = data.Rows[0].ItemArray[2].ToString();
            if (data.Rows[0].ItemArray[3].ToString() == "TCP")
                rbTCP.Checked = true;
            else
                rbUDP.Checked = true;
        }

        private void mSave_Click(object sender, EventArgs e)
        {
            if (curId == 0)
            {
                myFWDataSetTableAdapters.ProgramTableAdapter ta = new myFWDataSetTableAdapters.ProgramTableAdapter();
                var data = ta.Insert(tbxName.Text, tbxPort.Text, rbTCP.Checked ? "TCP" : "UDP");
                Close();
            }
            else
            {
                myFWDataSetTableAdapters.ProgramTableAdapter ta = new myFWDataSetTableAdapters.ProgramTableAdapter();
                var data = ta.myUpdate(tbxName.Text, tbxPort.Text, rbTCP.Checked ? "TCP" : "UDP", curId);
                Close();
            }
            change();
        }
    }
}
