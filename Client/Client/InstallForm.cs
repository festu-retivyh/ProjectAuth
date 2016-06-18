using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class InstallForm : Form
    {
        public string pin;
        public InstallForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxPin.Text == tbxpin2.Text && tbxPin.Text.Length > 3)
            {
                pin = tbxPin.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Введенные пин-коды не совпадают, повторите попытку.");
                tbxPin.Text = "";
                tbxpin2.Text = "";
            }
        }

        private void InstallForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pin == null)
            {
                throw new Exception("Закрытие данного окна привело к прекращению установки Клиента");
            }
        }
    }
}
