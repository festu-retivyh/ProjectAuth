using System;
using System.IO;
using System.Threading;

namespace Client
{
    public class TimerAlive
    {
        private static int time=30000;
        static Thread myTimer = new Thread(AliveSend);

        private static void AliveSend()
        {
            //File.WriteAllText(@"d:\aliveSend.txt", DateTime.Now + "  " + myTimer.ThreadState);
            Model.SendAliveMessage();
            Thread.Sleep(time);
            AliveSend();
        }

        public TimerAlive(int v)
        {
            time = v;
        }

        internal void Start()
        {
            myTimer.Start();
        }
    }
}