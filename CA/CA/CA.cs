
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace CA
{
    public class CA : ICA
    {
        public void AliveClient(string data)
        {
            OperationContext context = OperationContext.Current;
            MessageProperties prop = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint = prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            string ip = endpoint.Address;
            Model.AliveClient(data, ip);
        }

        public void AliveServer(string data)
        {
            Model.AliveServer(data);
        }

        public bool IsAlive()
        {
            return true;
        }

        public string JoinClient(string data)
        {
            OperationContext context = OperationContext.Current;
            MessageProperties prop = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint = prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            string ip = endpoint.Address;
            string returnData = Model.JoinClient(data, ip);
            return returnData;
        }

        public string JoinServer(string data)
        {
            string returnData = Model.JoinServer(data);
            return returnData;
        }

        public string RegistrateClient(string data)
        {
            string returnData = Model.RegistrateClient(data);
            return returnData;
        }

        public string RegistrateServer(string data)
        {
            string returnData = Model.RegistrateServer(data);
            return returnData;
        }
    }
}
