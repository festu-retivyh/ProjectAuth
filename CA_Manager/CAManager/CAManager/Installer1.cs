using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CAManager
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            //string privKey = Cryptography.Cryptography.GeneratePrivateKey();
            //File.WriteAllText(@"D:\ca.key", privKey);
            ////string path = @"c:\MyTest.txt";

            ////// This text is added only once to the file.
            ////if (!File.Exists(path))
            ////{
            ////    // Create a file to write to.
            ////    string createText = "Hello and Welcome" + Environment.NewLine;
            ////    File.WriteAllText(path, createText);
            ////}

        }
    }
}
