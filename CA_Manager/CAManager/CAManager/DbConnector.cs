using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAManager
{
    static class DbConnector
    {
        internal static int AddCertificate(Cryptography.Certificate newCert)
        {
            myFWDataSetTableAdapters.InsertCertificateTableAdapter tbCertificate = new myFWDataSetTableAdapters.InsertCertificateTableAdapter();
            var idUsbCert = tbCertificate.GetData(newCert.publicKey, 1, newCert.dateStart,newCert.dateStop, newCert.dateCreating);
            int id = (int)idUsbCert[0][0];
            return id;
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

        internal static int AddClient(int idUsb, int idUser)
        {
            myFWDataSetTableAdapters.InsertClientTableAdapter tbClient = new myFWDataSetTableAdapters.InsertClientTableAdapter();
            var idClient = tbClient.GetData(idUsb, idUser, null, null);
            int id = (int)idClient[0][0];
            AddClientState(id, 1);
            return id;
        }

        internal static int AddClientState(int idClient, int idState)
        {
            myFWDataSetTableAdapters.ClientStateTableAdapter tbClientState = new myFWDataSetTableAdapters.ClientStateTableAdapter();
            int rezult = tbClientState.Insert(DateTime.Now, idClient, idState);
            return rezult;
        }

        internal static int AddNewServer(sSERVER server, int idCertificate)
        {
            myFWDataSetTableAdapters.InsertServerTableAdapter tbServer = new myFWDataSetTableAdapters.InsertServerTableAdapter();
            var idServer = tbServer.GetData(server.name, server.address, server.guid, idCertificate);
            int id = (int)idServer[0][0];
            return id;
        }

        internal static void ClearUsrSrv(int clientId)
        {
            myFWDataSetTableAdapters.ClearUsrSrvTableAdapter tb = new myFWDataSetTableAdapters.ClearUsrSrvTableAdapter();
            tb.GetData(clientId);
        }

        internal static int AddUsb(string guid, int idCertificateUsb, string hashUsb)
        {
            myFWDataSetTableAdapters.InsertUsbTableAdapter tbUsb = new myFWDataSetTableAdapters.InsertUsbTableAdapter();
            var idUsb = tbUsb.GetData(guid, idCertificateUsb, hashUsb,"");
            int id = (int)idUsb[0][0];
            return id;
        }

        internal static void AddUsrSrv(int clientId, int serverId, int port)
        {
            myFWDataSetTableAdapters.AddUsrSrvTableAdapter tb = new myFWDataSetTableAdapters.AddUsrSrvTableAdapter();
            tb.GetData(clientId, serverId, port);
        }
    }
}
