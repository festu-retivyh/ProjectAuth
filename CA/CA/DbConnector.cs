
using System;
using Cryptography;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;

namespace CA
{
    class DbConnector
    {
        private static SqlConnection GetConnection()
        {
            var connection = "Data Source=" + Model.server + ";Initial Catalog=ProjectAuth_DB;Integrated security=False;User Id=" + Model.login + ";Password = " + Model.pass + ";";
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
            }
            catch
            {
                conn = null;
            }
            return conn;
        }
        internal static void RegistrateClient(string guidUSB, string guidClient, Certificate certificate)
        {
            var conn = GetConnection();
            if (conn == null)
                return;
            string comm = @"EXEC [dbo].[InsertCertificate] @publicKey, @type, @start, @stop, @date, @guidClient ";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("publicKey", certificate.publicKey);
            cmd.Parameters.AddWithValue("type", 2);
            cmd.Parameters.AddWithValue("start", certificate.dateStart);
            cmd.Parameters.AddWithValue("stop", certificate.dateStop);
            cmd.Parameters.AddWithValue("date", certificate.dateCreating);
            cmd.Parameters.AddWithValue("guidClient", guidClient);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            int id = sdr.GetInt32(0);
            sdr.Close();
            sdr = null;
            cmd.Cancel();
            cmd = null;
            comm = @"EXEC [dbo].[RegistrateClient] @guidUsb,@guidClient,@idCert ";
            cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guidUsb", guidUSB);
            cmd.Parameters.AddWithValue("guidClient", guidClient);
            cmd.Parameters.AddWithValue("idCert", id);
            cmd.ExecuteNonQuery();
        }

        internal static void GetOnlineClients(ref List<objClient> list)
        {
            var conn = GetConnection();
            if (conn == null)
            {
                list.Clear();
                return;
            }
            string comm = "SELECT State.[Date], Client.Address, Client.Guid FROM (SELECT ClientState.ClientId, ClientState.[Date], ClientState.StateId FROM (SELECT MAX(date) AS DateT, clientId From ClientState Group by clientId) AS Filter LEFT JOIN ClientState on Filter.clientId=clientState.ClientId and Filter.DateT=ClientState.[date]) AS State LEFT JOIN Client on State.ClientId=Client.Id WHERE State.StateId=2";
            SqlCommand cmd = new SqlCommand(comm, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            list.Clear();
            while (sdr.Read())
            {
                list.Add(new objClient(sdr.GetValue(2).ToString(), sdr.GetValue(1).ToString(), sdr.GetDateTime(0)));
            }
        }

        internal static void ClientAlive(string guidClient)
        {
            var conn = GetConnection();
            if (conn == null)
                return;
            string comm = @"Update [dbo].[ClientState] SET [date]=@date where id = (select TOP(1) id from ClientState where clientid = (select id from client where guid = @guid) Order by date desc)";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidClient);
            cmd.Parameters.AddWithValue("date", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        internal static bool CheckStateClient(string guidClient, string ip)
        {
            var conn = GetConnection();
            if (conn == null)
                return false;
            string comm = @"Select TOP(1) ClientState.stateid, client.address, ClientState.date from ClientState left join Client on clientState.clientid=client.id where clientid = (select id from client where guid = @guid) Order by date desc";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidClient);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                if (sdr.GetInt32(0) == 2 && sdr.GetValue(1).ToString() == ip && sdr.GetDateTime(2).AddMinutes(5) > DateTime.Now)
                    return true;
            }
            return false;
        }

        internal static void SetPartKey(string guidUSB, string partKey)
        {
            var conn = GetConnection();
            if (conn == null)
                return;
            string comm = @"Update USB SET partKey=@key where guid = @guid";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidUSB);
            cmd.Parameters.AddWithValue("key", partKey);
            cmd.ExecuteNonQuery();
        }

        internal static string [,] GetServersForClient(string guidClient)
        {
            throw new NotImplementedException();
        }

        internal static string GetGuidClientOfUsb(string guidUsb)
        {
            var conn = GetConnection();
            if (conn == null)
                return null;
            string comm = @"Select Client.guid from usb left join client on usb.id=client.usbid where usb.guid=@guid";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidUsb);
            SqlDataReader sdr = cmd.ExecuteReader();
            string guid = "";
            if (sdr.Read())
            {
                guid = sdr.GetValue(0).ToString();
            }
            return guid;
        }

        internal static void SetStateClient(string guidClient, string state, string ip="")
        {
            var conn = GetConnection();
            if (conn == null)
                return;
            string comm = @"Update Client SET address=@ip where guid = @guid";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidClient);
            cmd.Parameters.AddWithValue("ip", ip);
            cmd.ExecuteNonQuery();
            cmd.Cancel();
            comm = @"Insert INTO [dbo].[ClientState] ([date],[clientId],[stateId]) VALUES (@date, (Select id from client where guid=@guid), @state)";
            cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidClient);
            cmd.Parameters.AddWithValue("date", DateTime.Now);
            if(state=="active")
                cmd.Parameters.AddWithValue("state", 2);
            else if (state == "auth")
                cmd.Parameters.AddWithValue("state", 3);
            else
                cmd.Parameters.AddWithValue("state", 1);
            cmd.ExecuteNonQuery();
        }

        internal static void SetCertificateStatus(string guid, string status)
        {
            var conn = GetConnection();
            if (conn == null)
                return;
            string comm = @"Insert INTO [dbo].[CertificateStatus] ([CertificateId],[statusId],[date]) VALUES ((Select id from [dbo].[Certificate] where guid=@guid), @state, @date)";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guid);
            cmd.Parameters.AddWithValue("date", DateTime.Now);
            cmd.ExecuteNonQuery();
            if (status == "active")
                cmd.Parameters.AddWithValue("state", 2);
            else if (status == "block")
                cmd.Parameters.AddWithValue("state", 3);
            else if (status == "timeEnd")
                cmd.Parameters.AddWithValue("state", 4);
            else
                cmd.Parameters.AddWithValue("state", 1);
            cmd.ExecuteNonQuery();
        }

        internal static Certificate GetCertificate(string guid)
        {
            var conn = GetConnection();
            if (conn == null)
                return null;
            string comm = @"EXEC [dbo].[GetCertificate] @guid ";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guid);
            SqlDataReader sdr = cmd.ExecuteReader();
            Certificate cert = new Certificate();
            if (sdr.Read())
            {
                cert.dateCreating = sdr.GetDateTime(6);
                cert.dateStart = sdr.GetDateTime(4);
                cert.dateStop = sdr.GetDateTime(5);
                cert.publicKey = sdr.GetValue(2).ToString();// [0].publicKey;
                //text = text + sdr.GetValue(0).ToString();
            }
            return cert;
        }

        internal static string GetOnlineClientsForServer(string guid)
        {
            var conn = GetConnection();
            if (conn == null)
                return null;
            string comm = @"SELECT Client.address FROM Client INNER JOIN ClientServer ON Client.id = ClientServer.clientId INNER JOIN Server ON ClientServer.serverId = Server.id WHERE (Server.guid = @guid)";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guid);
            SqlDataReader sdr = cmd.ExecuteReader();
            string address = "";
            while (sdr.Read())
            {
                if (address == "")
                    address = sdr.GetValue(0).ToString();
                else
                    address = address + ";" + sdr.GetValue(0).ToString();
            }
            return address;
        }

        internal static void InsertTempGuid(string guid, string clientGuid)
        {
            var conn = GetConnection();
            if (conn == null)
                return;
            string comm = @"EXEC insertTempGuid @guid, @ClientGuid ";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guid);
            cmd.Parameters.AddWithValue("ClientGuid", clientGuid);
            cmd.ExecuteNonQuery();
        }

        internal static string GetPrivateKey()
        {
            var conn = GetConnection();
            if (conn == null)
                return null;
            string comm = @"Select [value] from parametrs where [property]='PrivateKey'";
            SqlCommand cmd = new SqlCommand(comm, conn);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
                return reader.GetValue(0).ToString();
            return null;
        }

        internal static string GetPartKeyUsb(string guidClient)
        {
            var conn = GetConnection();
            if (conn == null)
                return null;
            string comm = @"EXEC GetPartKey @guid ";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidClient);
            SqlDataReader sdr = cmd.ExecuteReader();
            string key = "";
            if (sdr.Read())
            {
                key = sdr.GetValue(0).ToString();
            }
            return key;
        }

        internal static string CheckTocken(string goodData, string guidUsb)
        {
            var conn = GetConnection();
            if (conn == null)
                return null;
            string comm = @"SELECT TempGuid.guid, TempGuid.date FROM  Client INNER JOIN Usb ON Client.usbId = Usb.id INNER JOIN TempGuid ON Client.id = TempGuid.clientId WHERE (Usb.guid = @guid) Order by TempGuid.id desc";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidUsb);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                if (goodData == sdr.GetValue(0).ToString() && sdr.GetDateTime(1).AddMinutes(1)>DateTime.Now)
                {
                    return "good";
                }
            }
            return "not good";
        }

        internal static Certificate GetCertificateUsbOfClient(string guidClient)
        {
            var conn = GetConnection();
            if (conn == null)
                return null;
            string comm = @"EXEC [dbo].[GetUsbCertificateOfClient] @guid ";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidClient);
            SqlDataReader sdr = cmd.ExecuteReader();
            Certificate cert = new Certificate();
            if (sdr.Read())
            {
                cert.dateCreating = sdr.GetDateTime(3);
                cert.dateStart = sdr.GetDateTime(1);
                cert.dateStop = sdr.GetDateTime(2);
                cert.publicKey = sdr.GetValue(0).ToString();// [0].publicKey;
                //text = text + sdr.GetValue(0).ToString();
            }
            return cert;
        }

        internal static Certificate GetUSBCertificate(string guidUsb)
        {
            var conn = GetConnection();
            if (conn == null)
                return null;
            string comm = @"EXEC [dbo].[GetUsbCert] @guid ";
            SqlCommand cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue("guid", guidUsb);
            SqlDataReader sdr = cmd.ExecuteReader();
            Certificate cert = new Certificate();
            if (sdr.Read())
            {
                //cert.dateCreating = sdr.GetValue[0].date;
                //cert.dateStart = rez[0].dateStart;
                //cert.dateStop = rez[0].dateStop;
                cert.publicKey = sdr.GetValue(1).ToString();// [0].publicKey;
                //text = text + sdr.GetValue(0).ToString();
            }
            return cert;
        }
    }
}
