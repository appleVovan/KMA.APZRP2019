using System.ServiceModel;
using KMA.APZRP2019.WalletSimulator.DBModels;
namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var serv = new ServiceReference1.WalletSimulatorClient("ServerWCFIIS");
            var users = serv.GetAllUsers();

            //using (var channelFactory = new ChannelFactory<IWalletSimulator>("Server"))
            //{
            //    IWalletSimulator proxy = channelFactory.CreateChannel();
            //    var user = new User("1", "1", "1", "1");
            //    proxy.AddUser(user);
            //}
            //using (var channelFactory = new ChannelFactory<IWalletSimulator>("Server"))
            //{
            //    IWalletSimulator proxy = channelFactory.CreateChannel();
            //    var userList = proxy.GetAllUsers();
            //}            
        }
    }
}
