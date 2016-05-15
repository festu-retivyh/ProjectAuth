using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA
{
    public static class ConfigurateSattings
    {
        public static void setMainSettings(string v1)
        {
            CASettings.Default.Setting = v1;
            CASettings.Default.Save();
        }
    }
}
