using System;

namespace CAManager
{
    static class DbConnector
    {
        internal static int AddCertificate(Cryptography.Certificate newCert)
        {
            myFWDataSetTableAdapters.InsertCertificateTableAdapter tbCertificate = new myFWDataSetTableAdapters.InsertCertificateTableAdapter();
            var idUsbCert = tbCertificate.GetData(newCert.publicKey, 1, newCert.dateStart,newCert.dateStop, newCert.dateCreating, newCert.sign, null);
            int id = (int)idUsbCert[0][0];
            return id;
        }

        internal static string getGroupName(int id)
        {
            myFWDataSetTableAdapters.GroupTableAdapter ta = new myFWDataSetTableAdapters.GroupTableAdapter();
            return ta.GetName(id);
        }

        internal static string GetParam(string proprty)
        {
            myFWDataSetTableAdapters.ParametrsTableAdapter ta = new myFWDataSetTableAdapters.ParametrsTableAdapter();
            string str = ta.GetValue(proprty);
            if (str != null)
                return str;
            return null;
        }

        internal static int AddCertificateStatus(int idCertificate, int idStatus)
        {
            myFWDataSetTableAdapters.CertificateStatusTableAdapter tbCertificateStatus = new myFWDataSetTableAdapters.CertificateStatusTableAdapter();
            int rezult = tbCertificateStatus.Insert(idCertificate, idStatus, DateTime.Now);
            return rezult;
        }

        internal static int addUser(sUSER user)
        {
            myFWDataSetTableAdapters.InsertUserTableAdapter tbUser = new myFWDataSetTableAdapters.InsertUserTableAdapter();
            var idUser = tbUser.GetData(user.surname, user.name, user.patronymic, user.login, user.domain);
            int id = (int)idUser[0][0];
            return id;
        }

        internal static void DeleteProfile(int id)
        {
            myFWDataSetTableAdapters.ProfileTableAdapter ta = new myFWDataSetTableAdapters.ProfileTableAdapter();
            ta.myDelete(id);
        }

        internal static void SetNameGroup(int id, string newName, string oldName)
        {
            myFWDataSetTableAdapters.GroupTableAdapter ta = new myFWDataSetTableAdapters.GroupTableAdapter();
            ta.myUpdate(newName, id);
        }

        internal static int AddGroup(string name)
        {
            myFWDataSetTableAdapters.GroupTableAdapter ta = new myFWDataSetTableAdapters.GroupTableAdapter();
            return ta.myInsert(name);
        }

        internal static void ClearGroupProfile(int groupId)
        {
            myFWDataSetTableAdapters.GroupProfileTableAdapter ta = new myFWDataSetTableAdapters.GroupProfileTableAdapter();
            ta.myDelete(groupId);
        }

        internal static void SetProfilesForGroup(int groupId, int[] profiles)
        {
            myFWDataSetTableAdapters.GroupProfileTableAdapter tb = new myFWDataSetTableAdapters.GroupProfileTableAdapter();
            foreach (int prof in profiles)
                tb.Insert(groupId, prof);
        }

        internal static int AddClient(int idUsb, int idUser)
        {
            myFWDataSetTableAdapters.InsertClientTableAdapter tbClient = new myFWDataSetTableAdapters.InsertClientTableAdapter();
            var idClient = tbClient.GetData(idUsb, idUser, null, null);
            int id = (int)idClient[0][0];
            AddClientState(id, 1);
            return id;
        }

        internal static void ClearClientProfile(int clientId)
        {
            myFWDataSetTableAdapters.ClientProfileTableAdapter ta = new myFWDataSetTableAdapters.ClientProfileTableAdapter();
            ta.myDelete(clientId);
        }

        internal static int AddClientState(int idClient, int idState)
        {
            myFWDataSetTableAdapters.ClientStateTableAdapter tbClientState = new myFWDataSetTableAdapters.ClientStateTableAdapter();
            int rezult = tbClientState.Insert(DateTime.Now, idClient, idState);
            return rezult;
        }

        internal static void SetProfilesForClient(int clientId, int[] profiles)
        {
            myFWDataSetTableAdapters.ClientProfileTableAdapter tb = new myFWDataSetTableAdapters.ClientProfileTableAdapter();
            foreach (int prof in profiles)
                tb.Insert(clientId, prof);
        }

        internal static int[] GetProfileForGroup(int groupId)
        {
            myFWDataSetTableAdapters.GroupProfileTableAdapter tb = new myFWDataSetTableAdapters.GroupProfileTableAdapter();
            var dt = tb.GetData();
            var mas = dt.Select("groupId=" + groupId.ToString());
            int[] myMas = new int[mas.Length];
            for(int i=0;i<mas.Length;i++)
            {
                myMas[i] = (int)mas[i].ItemArray[1];
            }
            return myMas;
        }

        internal static int AddNewServer(sSERVER server, int idCertificate)
        {
            myFWDataSetTableAdapters.InsertServerTableAdapter tbServer = new myFWDataSetTableAdapters.InsertServerTableAdapter();
            var idServer = tbServer.GetData(server.name, server.address, server.guid, idCertificate);
            int id = (int)idServer[0][0];
            return id;
        }
        
        internal static int AddUsb(string guid, int idCertificateUsb, string hashUsb)
        {
            myFWDataSetTableAdapters.InsertUsbTableAdapter tbUsb = new myFWDataSetTableAdapters.InsertUsbTableAdapter();
            var idUsb = tbUsb.GetData(guid, idCertificateUsb, hashUsb,"");
            int id = (int)idUsb[0][0];
            return id;
        }

        
    }
}
