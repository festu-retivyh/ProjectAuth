using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAManager
{
    //class GlobalStractures
    //{
    //}
    public struct sCLIENT_INFO_FULL
    {
        public string fio;
        public string ipAddress;
        public string status;
        public int clientId;
    }
    public struct sUSER
    {
        public int id;
        public string surname;
        public string guid;
        public string name;
        public string patronymic;
        public string login;
        public string domain;
        public bool deleted;
    }
    public struct sSERVER
    {
        public int id;
        public string name;
        public string address;
        public DateTime dateStart;
        public DateTime dateStop;
        public string publicKey;
        public int currentStatusId;
        public string guid;
    }
}
