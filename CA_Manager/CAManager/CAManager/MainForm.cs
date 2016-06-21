using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAManager
{
    public partial class MainForm : Form
    {
        private Button currentMenu;
        private TabControl.TabPageCollection allTabs;
        public MainForm()
        {
            InitializeComponent();
            allTabs = new TabControl.TabPageCollection(new TabControl());
            foreach (TabPage tab in mainTabsControl.TabPages)
                allTabs.Add(tab);
            Model.UpdateViewTables += M_UpdateViewTables;
        }

        private void M_UpdateViewTables(object sender, EventArgs e)
        {
            UpdateTables();
        }

        private void UpdateForm(object sender)
        {
            foreach (TabPage tab in mainTabsControl.TabPages)
            {
                allTabs.Add(tab);
            }
            currentMenu.BackColor = Color.LightGray;
            currentMenu = (Button)sender;
            currentMenu.BackColor = Color.Gray;
            if (currentMenu.Name == "btnStatistic")
            {
                mainTabsControl.TabPages.Add(allTabs["tabStatistic"]);
            }
            else if(currentMenu.Name == "btnUsers")
            {
                mainTabsControl.TabPages.Add(allTabs["tabOnlineUsers"]);
                mainTabsControl.TabPages.Add(allTabs["tabAllUsers"]);
                mainTabsControl.TabPages.Add(allTabs["tabBlockUsers"]);
                mainTabsControl.TabPages[0].Show();
            }
            else if (currentMenu.Name == "btnServers")
            {
                mainTabsControl.TabPages.Add(allTabs["tabServers"]);
            }
            else if (currentMenu.Name == "btnCertificate")
            {
                mainTabsControl.TabPages.Add(allTabs["tabValidCertificates"]);
                mainTabsControl.TabPages.Add(allTabs["tabBlockedCerificates"]);
                mainTabsControl.TabPages[0].Show();
            }
            else if (currentMenu.Name == "btnSettings")
            {
                mainTabsControl.TabPages.Add(allTabs["tabGeneralSettings"]);
                mainTabsControl.TabPages.Add(allTabs["tabSecuritySettings"]);
                mainTabsControl.TabPages[0].Show();
            }
            else if (currentMenu.Name == "btnLogs")
            {
                mainTabsControl.TabPages.Add(allTabs["tabLogs"]);
                mainTabsControl.TabPages[0].Show();
            }
            else mainTabsControl.TabPages.Add(allTabs[0]);
        }
        private void UpdateDataForm()
        {
            //onlineClientsBindingSource.DataSource = onlineClientsTableAdapter.GetData();
            //clientsLastStatesBindingSource1.DataSource = clientsLastStatesTableAdapter.GetData();
            //clientsLastStatesBindingSource1.Filter = "stateId = 2";
            ////clientsLastStatesBindingSource.DataSource = clientsLastStatesTableAdapter.GetData();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            UpdateForm(sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UpdateForm(sender);
        }
        private void btnServers_Click(object sender, EventArgs e)
        {
            UpdateForm(sender);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            UpdateForm(sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTables();
                        
            currentMenu = btnStatistic;
            UpdateForm(btnStatistic);
        }
        private void UpdateTables()
        {
            serverTableAdapter.Fill(myFWDataSet.Server);
            onlineClientStateTableAdapter.Fill(myFWDataSet.OnlientClientsState);
            lastClientsStatesTableAdapter.Fill(myFWDataSet.LastClientsStates);
            timeEndCertsTableAdapter.Fill(myFWDataSet.TimeEndCerts);
            myHardLogTableAdapter.Fill(this.myFWDataSet.myHardLog);
            myLogsTableAdapter.Fill(this.myFWDataSet.myLogs);
        }

        private void btnSelectUserOnline_Click(object sender, EventArgs e)
        {

        }

        private void btnStopSession_Click(object sender, EventArgs e)
        {

        }

        private void btnBlockUserOnline_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            int idSelUser = (int)dgvAllUsers.SelectedRows[0].Cells[0].Value;
            sprClient spr = new sprClient(idSelUser);
            spr.Show();
        }

        private void btnBlockUserAll_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectUserBlocked_Click(object sender, EventArgs e)
        {

        }

        private void btnDeblockUser_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (tbxNewPass1.Text == tbxNewPass2.Text)
            {
                Settings.ChangePassword(tbxOldPass.Text, tbxNewPass1.Text);
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            UpdateForm(sender);
        }

        private void dgvOnlineUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddServerMasterOpen_Click(object sender, EventArgs e)
        {
            MasterAddServer m = new MasterAddServer();
            m.Show();
        }

        private void btnCertificateMasterOpen_Click(object sender, EventArgs e)
        {
            MasterAddClient m = new MasterAddClient();
            m.Show();
        }

        private void dgvAllUsers_DoubleClick(object sender, EventArgs e)
        {
            ControlClientProfile test = new ControlClientProfile(int.Parse(((DataGridView)sender).CurrentRow.Cells[0].Value.ToString()));
            test.Show();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            sprListGroup spr = new sprListGroup();
            spr.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            sprListProfile spr = new sprListProfile();
            spr.Show();
        }

        private void btnCert_Click(object sender, EventArgs e)
        {

        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            sprListProgram spr = new sprListProgram();
            spr.Show();
        }

        private void dgvServers_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvServers.SelectedRows[0].Cells[0].Value;
            sprServer spr = new sprServer(id);
            spr.Show();
        }
    }
}
