using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Server
{
    static class ControlFW
    {
        static bool threadWork=false;
        static int suspend = 1000, counterRules = 0;
        static Thread thread;
        static CmdProxy cmd = new CmdProxy();
        private static List<Rule> activRules = new List<Rule>();
        private static List<Rule> queueRules = new List<Rule>();

        public static void Start()
        {
            if (threadWork)
                return;
            thread = new Thread(new ThreadStart(secondThread));
            threadWork = true;
            thread.Start();
        }
        public static void Stop()
        {
            threadWork = false;
        }

        private static void secondThread()
        {
            if (!threadWork)
                return;
            suspend = CheckQueueRules();
            Thread.Sleep(suspend);
            secondThread();
        }

        private static int CheckQueueRules()
        {
            if(queueRules.Count==0)
                return 1000;
            cmd.Execute(GetCommand(queueRules[0]));
            return 0;
        }

        private static string GetCommand(Rule rule)
        {
            string str = "";
            if (rule.port == "")
            {
                rule.name = rule.protocol;
                str = "add rule name="+ rule.name + " protocol=" + rule.protocol + " action=allow dir=IN";
                activRules.Add(rule);
                queueRules.Remove(rule);
            }
            else
            {
                if (rule.action)
                {
                    rule.name = "ProjectAuth" + counterRules.ToString();
                    str = "add rule name=" + rule.name + " protocol=" + rule.protocol + " localport=" + rule.port + " action=allow dir=IN remoteip=" + rule.ip;
                    activRules.Add(rule);
                    queueRules.Remove(rule);
                    counterRules++;
                }
                else
                {
                    Rule curRule = GetActivRule(rule.port, rule.ip, rule.protocol);
                    if (curRule == null)
                    {
                        queueRules.Remove(rule);
                        return "";
                    }
                    str = "delete rule name = " + curRule.name;
                    activRules.Remove(curRule);
                    queueRules.Remove(rule);
                }
            }
            return str;
        }

        private static Rule GetActivRule(string port, string ip, string protocol)
        {
            try
            {
                for (int i = 0; i < activRules.Count; i++)
                {
                    if (activRules[i].port == port && activRules[i].ip == ip && activRules[i].protocol == protocol)
                        return activRules[i];
                }
            }
            catch
            { return null; }
            return null;
        }

        internal static void DelRule(string data)
        {
            if (data == "all")
            {
                Model.SendMessageForJoinCA();
            }
            else
            {
                var mas = data.Split(':');
                if (mas.Length == 3)
                    queueRules.Add(new Rule(mas[0], mas[1], mas[2], "", false));
            }
        }

        internal static void AddRule(string data)
        {
            var mas = data.Split(':');
            if(mas.Length==3)
                queueRules.Add(new Rule(mas[0],mas[1],mas[2],"",true));
        }

        internal static void SetListRules(string data)
        {
            if (activRules.Count == 0)
            {
                var masData = data.Split(';');
                cmd.Execute("set rule name=all dir=in new enable=no");
                cmd.Execute("set rule name=ProjectAuth_Server new enable=yes");
                for (int i = 0; i < masData.Length; i++)
                {
                    var mas = masData[i].Split(':');
                    if (mas.Length == 3)
                        queueRules.Add(new Rule(mas[0], mas[1], mas[2], "", true));
                    else if (mas.Length == 2)
                    {
                        queueRules.Add(new Rule("", "", mas[0], "", mas[1] == "Y" ? true : false));
                    }

                }
            }
            else
            {
                var masData = data.Split(';');
                List<Rule> temp = new List<Rule>();
                for (int i = 0; i < masData.Length; i++)
                {
                    var mas = masData[i].Split(':');
                    if (mas.Length == 3)
                        temp.Add(new Rule(mas[0], mas[1], mas[2], "", true));
                    else if (mas.Length == 2)
                    {
                        //Пока ничего не делаем
                        //temp.Add(new Rule("", "", mas[0], "", mas[1] == "Y" ? true : false));
                    }
                }
                bool find = false;

                for (int i = 0; i < activRules.Count; i++)
                {
                    for (int j = 0; i < temp.Count; j++)
                    {
                        if (temp[j].port == activRules[i].port && temp[j].ip == activRules[i].ip)
                        {
                            temp.Remove(temp[j]);
                            find = true;
                            break;
                        }
                    }
                    if (!find)
                    {
                        DelRule(activRules[i].ip + ":" + activRules[i].port + ":" + activRules[i].protocol);
                    }
                }
                foreach (var r in temp)
                {
                    AddRule(r.ip + ":" + r.port + ":" + r.protocol);
                }
            }
        }
    }
    class Rule
    {
        public string ip = "";
        public string port = "";
        public string protocol = "";
        public string name = "";
        public bool action;
        public Rule(string _ip, string _port, string _protocol, string _name, bool _action)
        {
            ip = _ip;
            port = _port;
            protocol = _protocol;
            name = _name;
            action = _action;
        }
    }
    class CmdProxy
    {
        public void Execute(string command)
        {
            var proc = new Process(); 
            proc.StartInfo.FileName = "netsh.exe";
            proc.StartInfo.Arguments = " advfirewall firewall " + command;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();
        }
        public void ExecuteAdv(string command)
        {
            var proc = new Process(); 
            proc.StartInfo.FileName = "netsh.exe";
            proc.StartInfo.Arguments = " advfirewall " + command;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();
        }
    }

}
