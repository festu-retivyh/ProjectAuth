using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAManager
{
    public partial class ControlUserSrv : Form
    {
        int currentClientId;
        public ControlUserSrv()
        {
            InitializeComponent();
        }
        public void ChangeUser(int id, string name)
        {
            //myFWDataSet.UserSrv.
            //userSrvTableAdapter.
            //tbxUser.Text = name;
            //currentClientId = id;
            //myFWDataSetTableAdapters.UserSrvTableAdapter userSvr = new myFWDataSetTableAdapters.UserSrvTableAdapter();
            //userSvr.Adapter.SelectCommand.Parameters.AddWithValue("clientId", currentClientId);
            //userSrvBindingSource.ResetBindings(false);

            tbxUser.Text = name;
            currentClientId = id;
            userSrvBindingSource.Filter = "clientId = "+ currentClientId.ToString();
            //userSrvTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("clientId", currentClientId);
            //userSrvBindingSource.ResetBindings(false);

            //dgvUserSrv.Update();
            //userSrvBindingSource.Filter = "clientId = " + id;
            //dgvUserSrv.DataSource
        }

        private void ControlUserSrv_Load(object sender, EventArgs e)
        {
            
            //query
            //SqlDataAdapter dataadapter = new SqlDataAdapter(query, userSrvTableAdapter.Connection);
            //string connectionString = "Data Source=.;Initial Catalog=pubs;Integrated Security=True";
            //string sql = "SELECT title_id,title,type,pub_id FROM Titles";
            //SqlConnection connection = new SqlConnection(connectionString);
            //SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            //connection.Open();
            //dataadapter.Fill(ds, "Titles_table");
            //connection.Close();

            //dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
