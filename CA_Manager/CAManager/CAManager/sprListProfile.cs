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
    public partial class sprListProfile : Form
    {
        public sprListProfile()
        {
            InitializeComponent();
        }

        private void sprListProfile_Load(object sender, EventArgs e)
        {
            myProfileTATableAdapter.Fill(myFWDataSet.myProfileTA);
            profileTableAdapter.Fill(myFWDataSet.Profile);

        }

        private void mAdd_Click(object sender, EventArgs e)
        {
            sprProfile spr = new sprProfile();
            spr.Show();
        }

        private void mSel_Click(object sender, EventArgs e)
        {
            sprProfile spr = new sprProfile((int)dgvProfile.SelectedRows[0].Cells[0].Value);
            spr.Show();
        }

        private void mDel_Click(object sender, EventArgs e)
        {
            var rezult = MessageBox.Show("Вы дейтвительно хотите удалить профиль: '" + dgvProfile.SelectedRows[0].Cells[1].Value + "'", "Действительно удалить элемент", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rezult==DialogResult.Yes)
                DbConnector.DeleteProfile((int)dgvProfile.SelectedRows[0].Cells[0].Value);

        }
    }
}
