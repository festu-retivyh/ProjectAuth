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
    public partial class sprServer : Form
    {
        int curId = 0;
        public delegate void ChangeInformation();
        public event ChangeInformation change;
        public sprServer()
        {
            InitializeComponent();
        }
        public sprServer(int serverId)
        {
            InitializeComponent();
            curId = serverId;
        }

        private void sprServer_Load(object sender, EventArgs e)
        {
            myFWDataSetTableAdapters.ServerTableAdapter ta = new myFWDataSetTableAdapters.ServerTableAdapter();
            var srv = ta.GetServerDT(curId);

            tbxAddress.Text = srv[0].address;
            tbxName.Text = srv[0].name;
            lblStatus.Text = "Статус сертификата: "+srv[0].ItemArray[9].ToString();
            lblDateCert.Text = "Дата создания: "+ srv[0].ItemArray[1].ToString();
            lblDateStart.Text = "Дата начала действия: " + srv[0].ItemArray[7].ToString();
            lblDateStop.Text = "Дата окончания действия: " + srv[0].ItemArray[8].ToString();
            FillProtocols();
            try
            {
                string prot = srv[0].protocols;
                string[] masProt = prot.Split(';');
                string[] mas;
                for (int i = 0; i < masProt.Length; i++)
                {
                    mas = masProt[i].Split(':');
                    if (mas[1] == "Y")
                        dgvProtocols.Rows[i].Cells[0].Value = true;
                }
            }
            catch { }
        }
        string[] listProt = new string[8] { "HOPOPT", "IGMP", "ICMPv4", "ICMPv6", "IPv6", "GRE", "PGM", "L2TP" };
        private void FillProtocols()
        {
            for (int i = 0; i < listProt.Length; i++)
                dgvProtocols.Rows.Add(new object[2] { false, listProt[i]});
        }

        private void сохранитьИЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myFWDataSetTableAdapters.ServerTableAdapter ta = new myFWDataSetTableAdapters.ServerTableAdapter();
            string prot="";
            for (int i = 0; i < dgvProtocols.Rows.Count; i++)
            {
                //if ((bool)dgvProtocols.Rows[i].Cells[0].Value)
                if(prot == "")
                    prot = dgvProtocols.Rows[i].Cells[1].Value.ToString() + ":" + ((bool)(dgvProtocols.Rows[i].Cells[0].Value) ? "Y" : "N");
                else
                    prot = prot + ";" + dgvProtocols.Rows[i].Cells[1].Value.ToString() + ":" + ((bool)(dgvProtocols.Rows[i].Cells[0].Value) ? "Y" : "N");
            }
            ta.myUpdate(tbxName.Text, tbxAddress.Text, prot, curId);
            change();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
