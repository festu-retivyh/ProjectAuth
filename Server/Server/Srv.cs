using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    public class Srv : ISrv
    {
        public void AddRule(string data)
        {
            ControlFW.AddRule(data);
        }

        public void DelRule(string data)
        {
            ControlFW.DelRule(data);
        }

        public bool IsAlive()
        {
            return true;
        }
    }
}
