using System.Data.Entity;
using KMA.APZRP2019.WalletSimulator.EntityFrameworkWrapper.Migrations;
using KMA.APZRP2019.WalletSimulator.EntityFrameworkWrapper.ModelConfiguration;
using User = KMA.APZRP2019.WalletSimulator.DBModels.User;

namespace KMA.APZRP2019.WalletSimulator.EntityFrameworkWrapper
{
    public class WalletDBContext:DbContext
    {
        //public WalletDBContext() : base(@"Server=KIYVMANAGERSURF\ARTSYLPRODUCTS10;Integrated security = true;database=WalletSimulator")
        public WalletDBContext() : base("DB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WalletDBContext, Configuration>());
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new DogConfiguration());
        }
    }
}
