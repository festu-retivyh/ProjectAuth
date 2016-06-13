using System;
using System.Windows.Forms;

namespace Client
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            
            InitializeComponent();
        }

        private void tbxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxNewPin1.Text != tbxNewPin2.Text)
                return;
            if (tbxNewPin1.Text.Length < 4)
                return;
            bool rezult = Model.ChangeUserPincode(tbxOldPin.Text, tbxNewPin1.Text);
            if (rezult)
                MessageBox.Show("Ваш пин-код успешно изменен");
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            if (Model.disk == null)
            {
                MessageBox.Show("Вставьте ваш токен в порт usb. После чего попытайтесь войти в настройки");
                Close();
            }
        }
    }
}
