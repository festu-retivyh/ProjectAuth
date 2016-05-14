using System.ServiceModel;

namespace CA
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ICA" в коде и файле конфигурации.
    [ServiceContract()]
    public interface ICA
    {
        [OperationContract()]
        string JoinClient(string data);
        [OperationContract()]
        string JoinServer(string data);
        [OperationContract()]
        string RegistrateClient(string data);
        [OperationContract()]
        string RegistrateServer(string data);
        [OperationContract()]
        void AliveClient(string data);
        [OperationContract()]
        void AliveServer(string data);
        [OperationContract()]
        bool IsAlive();
    }
}
