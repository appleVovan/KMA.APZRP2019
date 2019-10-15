using KMA.APZRP2019.WalletSimulator.DBModels;
using Tester.WalletWCFServiceIIS;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var restClient = new WalletSimulatorRestApiClient())
            {
                
                var user = new User("123", "123", "123456", "123");
                user.Dogs.Add(new Dog("Sharik"));
                restClient.AddUser(user);
                var users = restClient.GetAllUsers();
            }

            //WalletSimulatorClient serverClient = null;
            //try
            //{
            //    serverClient = new WalletWCFServiceIIS.WalletSimulatorClient("BasicHttpBinding_IWalletSimulator");
            //    var user = new User("12", "12", "12345", "12");
            //    user.Dogs.Add(new Dog("Sharik"));
            //    serverClient.AddUser(user);
            //    var users = serverClient.GetAllUsers();
            //}
            //finally
            //{
            //    serverClient?.Close();
            //}

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
