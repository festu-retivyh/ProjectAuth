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
            try
            {
                FillList();
            }
            catch { Model.AddLog("Ошибка в EventTimer.FillList"); }
            CheckOnlineClients();
            Thread.Sleep(60000);
        }

        private static void FillList()
        {
            DbConnector.GetOnlineClients(ref list);
        }

        private static void CheckOnlineClients()
        {
            int max = list.Count;
            for (int i = 0; i < max; i++)
            {
                try
                {
                    if (list[i].date.AddMinutes(5) <= DateTime.Now)
                    {
                        DbConnector.SetStateClient(list[i].guid, "off");
                        list.Remove(list[i]);
                        i--;
                        max--;
                    }
                }
                catch
                { Model.AddLog("Ошибка в EventTimer.CheckOnlineClients"); }
            }
        }

        public void Stop()
        {
            //CheckerOnline.Suspend();
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
