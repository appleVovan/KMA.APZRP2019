using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using KMA.APZRP2019.WalletSimulator.DBModels;
using KMA.APZRP2019.WalletSimulator.EntityFrameworkWrapper;
using KMA.APZRP2019.WalletSimulator.Server.Interface;

namespace KMA.APZRP2019.WalletSimulator.Server.Implementation
{
    public class WalletSimulatorImpl: IWalletSimulator
    {
        public void AddUser(User user)
        {
            using (var context = new WalletDBContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            using (var context = new WalletDBContext())
            {
                return context.Users.Include(u=>u.Dogs).ToList();
            }
        }
    }
}
