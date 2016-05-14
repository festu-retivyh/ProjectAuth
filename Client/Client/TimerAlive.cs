using System;
using System.Threading;

namespace Client
{
    internal class TimerAlive
    {
        private static int time=1000;
        Thread myTimer = new Thread(AliveSend);

        private static void AliveSend()
        {
            Model.SendAliveMessage();
            Thread.Sleep(time);
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