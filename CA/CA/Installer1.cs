using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;

namespace CA
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
            File.WriteAllText(@"d:\sett0.txt", CASettings.Default.Setting);
            CASettings.Default.Setting = Context.Parameters["dbname"];
            CASettings.Default.Save();
            File.WriteAllText(@"d:\sett1.txt", CASettings.Default.Setting);
            //CA.ConfigurateSattings.setMainSettings(Context.Parameters["dbname"]);
        }
    }
}
