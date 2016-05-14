using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace CA
{
    public class EventTimer
    {
        static List<objClient> list = new List<objClient>();
        Thread CheckerOnline; 
        public void Start()
        {
            CheckerOnline = new Thread(Timer);
            CheckerOnline.Start();

        }
        private static void Timer()
        {
            while (true)
                Alive();
        }

        private static void Alive()
        {
            FillList();
            CheckOnlineClients();
            Thread.Sleep(5000);
        }

        private static void FillList()
        {
            DbConnector.GetOnlineClients(ref list);
        }

        private static void CheckOnlineClients()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].date.AddMinutes(5) <= DateTime.Now)
                {
                    DbConnector.SetStateClient(list[i].guid, "off");
                    list.Remove(list[i]);
                    i--;
                    //state = DbConnector.CheckStateClient(list[i].guid, list[i].ip);
                    //if (state)
                    //{
                    //    list[i].date = list[i].date.AddSeconds(150);
                    //}
                    //else
                    //{
                        
                    //}
                }
            }
            //bool state;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].date.AddSeconds(150) <= DateTime.Now)
            //    {
            //        state = DbConnector.CheckStateClient(list[i].guid, list[i].ip);
            //        if (state)
            //        {
            //            list[i].date = list[i].date.AddSeconds(150);
            //        }
            //        else
            //        {
            //            DbConnector.SetStateClient(list[i].guid, "off");
            //            list.Remove(list[i]);
            //            i--;
            //        }
            //    }
            //}
        }

        public void Stop()
        {
            CheckerOnline.Suspend();
        }
    }
    class objClient
    {
        public string guid;
        public string ip;
        public DateTime date;

        public objClient(string _guid, string _ip, DateTime dateTime)
        {
            guid = _guid;
            ip = _ip;
            date = dateTime;
        }
    }
}
