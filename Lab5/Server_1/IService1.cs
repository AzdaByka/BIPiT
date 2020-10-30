using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server_1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        DataTable GetData();

        [OperationContract]
        DataTable GetClientSelectData();

        [OperationContract]
        DataTable GetBusSelectData();

        [OperationContract]
        string InsertMethod(string id_Client, string id_Bus, string date, string cost);


        [OperationContract]
        string RecCheck(string id_Client, string id_Bus, string date, string cost);

    }
}
