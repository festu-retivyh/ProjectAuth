using System;
using System.Windows.Forms;

namespace CAManager
{
    public partial class sprCert : Form
    {
        int curId;
        public sprCert(int id)
        {
            InitializeComponent();
            curId = id;
        }

        private void sprCert_Load(object sender, EventArgs e)
        {
            myFWDataSetTableAdapters.myCertificateTableAdapter ta = new myFWDataSetTableAdapters.myCertificateTableAdapter();
            var data = ta.GetDataCertForId(curId);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Не выбран сертификат","Ошибка");
                Close();
            }
        }
    }
}
