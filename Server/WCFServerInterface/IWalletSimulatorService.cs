using System.Collections.Generic;
using System.ServiceModel;
using KMA.APZRP2019.WalletSimulator.DBModels;

namespace KMA.APZRP2019.WalletSimulator.Server.Interface
{
    [ServiceContract]
    public interface IWalletSimulator
    {
        [OperationContract]
        IEnumerable<User> GetAllUsers();

        [OperationContract]
        void AddUser(User user);
    }
}
