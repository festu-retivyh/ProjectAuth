using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Management;
using System.ServiceModel;

namespace Client
{
    public partial class Form1 : Form
    {
        #region values
        Thread searchUsbThread = new Thread(SearchUsb);
        UsbDisk disk;
        string[] fileUsb, fileClient;
        string curUsb, curComp, privateKeyClient, hashUsb;
        TimerAlive ta;
        #endregion

        public Form1()
        {
            ta = new TimerAlive(30000);
            InitializeComponent();
            ta.Start();

            notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
            Resize += new EventHandler(Form1_Resize);

            UsbSearcher.onAddUsb += UsbSearcher_onAddUsb;
            UsbSearcher.onDelUsb += UsbSearcher_onDelUsb;
            searchUsbThread.Start();
        }

        private void UsbSearcher_onDelUsb(UsbDisk nameDisk)
        {
            Model.SendAliveMessage(false);
            if (Model.disk == nameDisk)
            {
                Model.disk = null;
            }
        }

        void UsbSearcher_onAddUsb(UsbDisk nameDisk)
        {
            if (Model.disk == null)
                CheckFile(nameDisk);
        }

        private void CheckFile(UsbDisk _disk)
        {
            if (File.Exists(_disk.name + @"\maan.key")) //Если имеется наш зашифрованный файл
            {
                curUsb = UsbSearcher.infoUsbGet(_disk);
                curComp = infoAboutComputer();
                fileUsb = File.ReadAllText(_disk.name + @"\maan.key").Split(' ');
                hashUsb = curUsb;
                for (int i = 0; i < 100; i++)
                    hashUsb = Cryptography.Cryptography.GetHash(hashUsb);
                curComp = Cryptography.Cryptography.GetHash(curComp);

                fileClient = File.ReadAllText(@"C:\ProgramData\ClientKey\prv.key").Split(' ');
                string HashSKeyClient = fileClient[3];
                disk = _disk;
                if (Cryptography.Cryptography.GetHash(hashUsb + curComp) != HashSKeyClient)
                    return;
                label1.Invoke(new Action(delegate ()
                {
                    label1.Text = "Файл найден";
                }));
                this.Invoke(new Action(delegate ()
                {
                    Show();
                    notifyIcon1.Visible = false;
                    WindowState = FormWindowState.Normal;
                }));
                label1.Invoke(new Action(delegate ()
                {
                    label1.Text = "Введите PIN-код";
                }));

            }
        }

        private static void SearchUsb()
        {
            while (true)
            {
                UsbSearcher.Search();
                Thread.Sleep(500);
            }
        }

        private void ClearTempValues()
        {
            fileUsb = null;
            fileClient = null;
            curUsb = "";
            curComp = "";
            privateKeyClient = "";
            Model.guidClient = "";
            Model.pubKeyCA = "";
        }

        private string GenerateJoinMessage()
        {
            ConstractorMessage cm = new ConstractorMessage();
            return cm.GetEncriptMessage(Model.pubKeyCA, privateKeyClient, "1", Model.guidClient);
        }

        private string GenerateAcceptTocken(string message)
        {

            string usbData = fileUsb[0];
            string[] masMessage = message.Split(' ');
            string sKeyUsb = Model.genSKeyUsb(hashUsb, masMessage[2]);
            string criptDataUsb = masMessage[3];
            criptDataUsb = Cryptography.Cryptography.DecryptAes(usbData, sKeyUsb, hashUsb);
            string guidUsb = criptDataUsb.Split(' ')[0];
            string privKeyUsb = criptDataUsb.Split(' ')[1];
            message = masMessage[3].Replace("!!!!!", " ");
            message = ReadMessage(message, privKeyUsb);

            ConstractorMessage cm = new ConstractorMessage();
            cm.AddData(message.Split(' ')[2]);
            return cm.GetEncriptMessage(Model.pubKeyCA, privKeyUsb, "2", guidUsb);
        }

        private string ReadMessage(string messageFromCA, string privateKey)
        {
            var allEncriptData = Cryptography.Cryptography.Decrypt(messageFromCA, privateKey);
            string[] masData = allEncriptData.Split(' ');
            try
            {
                if (!(int.Parse(masData[0]) == masData.Length))
                    return "1";
                if (!(CheckSing(masData)))
                    return "2";
                string rezultData = masData[1];
                for (int i = 2; i < int.Parse(masData[0]) - 2; i++)
                    rezultData += " " + masData[i];
                string dataForCheckHash = masData[0] + " " + rezultData;
                if (!(Cryptography.Cryptography.GetHash(dataForCheckHash) == masData[masData.Length - 2]))
                    return "3";
                return rezultData;
            }
            catch { return "4"; }
        }

        private bool CheckSing(string[] masData)
        {
            string dataForCheck = masData[0];
            for (int i = 1; i < masData.Length - 1; i++)
            {
                dataForCheck += " " + masData[i];
            }
            return Cryptography.Cryptography.CheckSign(dataForCheck, masData[masData.Length - 1], Model.pubKeyCA);
        }

        private string infoAboutUsb(UsbDisk _disk)
        {
            return UsbSearcher.infoUsbGet(_disk);
        }
        private string infoAboutComputer()
        {
            string data = "";

            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                if (wmi_HD["SerialNumber"] == null)
                    data += Cryptography.Cryptography.GetHash("None");
                else
                    data += Cryptography.Cryptography.GetHash(wmi_HD["SerialNumber"].ToString());
            }
            if (data == "")
                Cryptography.Cryptography.GetHash("IJ|lT1Tl|IJ");
            return data;
        }
        internal static CAService.CAClient CreateWebServiceInstance()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            // I think most (or all) of these are defaults--I just copied them from app.config:
            binding.SendTimeout = TimeSpan.FromMinutes(1);
            binding.OpenTimeout = TimeSpan.FromMinutes(1);
            binding.CloseTimeout = TimeSpan.FromMinutes(1);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(5);
            binding.AllowCookies = false;
            binding.BypassProxyOnLocal = false;
            binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            binding.MessageEncoding = WSMessageEncoding.Text;
            binding.TextEncoding = System.Text.Encoding.UTF8;
            binding.TransferMode = TransferMode.Buffered;
            binding.UseDefaultWebProxy = true;
            return new CAService.CAClient(binding, new EndpointAddress("http://192.168.68.100:45000/CA.CA"));
        }

        #region FormEvents

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void iAmAliveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Model.SendAliveMessage();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!notifyIcon1.Visible)
            {
                e.Cancel = true;
                Hide();
                notifyIcon1.Visible = true;
                ClearTempValues();
            }
            else
                searchUsbThread.Abort();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string hashPin = Cryptography.Cryptography.GetHash(tbxPinCode.Text);
            tbxPinCode.Text = "";
            Model.hashPin = hashPin;
            string sKeyClient = Model.GetSKeyClient(fileClient[1], curComp, hashUsb, hashPin);
            string[] decriptDataClient = Cryptography.Cryptography.DecryptAes(fileClient[0], sKeyClient, hashUsb).Split(' ');
            privateKeyClient = decriptDataClient[0];
            Model.guidClient = decriptDataClient[1];
            Model.pubKeyCA = decriptDataClient[2];
            var ca = CreateWebServiceInstance();
            //ca.Open();
            try
            {
                ca.IsAlive(new CAService.IsAliveRequest());
            }
            catch (EndpointNotFoundException err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            string messageFromCA = ca.JoinClient(new CAService.JoinClientRequest(GenerateJoinMessage())).JoinClientResult;

            messageFromCA = ReadMessage(messageFromCA, privateKeyClient);
            messageFromCA = ca.JoinClient(new CAService.JoinClientRequest(GenerateAcceptTocken(messageFromCA))).JoinClientResult;
            ca.Close();
            Close();
            if (Model.disk == null)
                Model.disk = disk;
        }
        private void CloseApp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Name);
            //Close();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        #endregion
    }
}
