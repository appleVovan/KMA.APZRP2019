using System.Collections.Generic;
using KMA.APZRP2019.WalletSimulator.DBModels;
using KMA.APZRP2019.WalletSimulator.Server.Implementation;
using KMA.APZRP2019.WalletSimulator.Server.Interface;

namespace MA.APZRP2019.WalletSimulator.Server.WCFServerIIS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WalletWCFServiceIIS" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WalletWCFServiceIIS.svc or WalletWCFServiceIIS.svc.cs at the Solution Explorer and start debugging.
    public class WalletWCFServiceIIS : IWalletSimulator
    {
        private WalletSimulatorImpl service = new WalletSimulatorImpl();
        public IEnumerable<User> GetAllUsers()
        {
            return service.GetAllUsers();
        }

        public void AddUser(User user)
        {
            service.AddUser(user);
        }
    }
}
