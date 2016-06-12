using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IServer" в коде и файле конфигурации.
    [ServiceContract]
    public interface ISrv
    {
        [OperationContract]
        void AddRule(string data);
        [OperationContract]
        void DelRule(string data);
        [OperationContract]
        bool IsAlive();
    }
}
