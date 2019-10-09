using System.Collections.Generic;
using System.Linq;
using KMA.APZRP2019.WalletSimulator.DBModels;
using KMA.APZRP2019.WalletSimulator.Server.Interface;
using KMA.APZRP2019.WalletSimulator.Tools;

namespace KMA.APZRP2019.WalletSimulator.Server.Implementation
{
    public class WalletSimulatorImpl: IWalletSimulator
    {
        public void AddUser(User user)
        {
            using (var dbProvider = ProviderFactory.CreateNewDBProvider())
            {
                dbProvider.Add(user);
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            using (var dbProvider = ProviderFactory.CreateNewDBProvider())
            {
                return dbProvider.SelectAll<User>().ToList();
            }
        }
    }
}
