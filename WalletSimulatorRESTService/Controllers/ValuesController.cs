using System.Collections.Generic;
using System.Web.Http;
using KMA.APZRP2019.WalletSimulator.DBModels;
using KMA.APZRP2019.WalletSimulator.Server.Implementation;
using KMA.APZRP2019.WalletSimulator.Server.Interface;

namespace WalletSimulatorRESTService.Controllers
{
    public class ValuesController : ApiController, IWalletSimulator
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
