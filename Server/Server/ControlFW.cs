using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ControlFW
    {
        internal static void DelRule(string data)
        {
            File.WriteAllText(@"d:\DelRule.txt", data);
        }
        internal static void AddRule(string data)
        {
            File.WriteAllText(@"d:\addRule.txt", data);
        }

        internal static void SetListRules(string data)
        {
            File.WriteAllText(@"d:\SetListRules.txt", data);
        }


    }
}
