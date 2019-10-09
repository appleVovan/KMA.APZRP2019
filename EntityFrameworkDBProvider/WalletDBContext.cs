using System.Data.Entity;
using KMA.APZRP2019.WalletSimulator.Providers.DB.EntityFramework.Migrations;
using KMA.APZRP2019.WalletSimulator.Providers.DB.EntityFramework.ModelConfiguration;
using User = KMA.APZRP2019.WalletSimulator.DBModels.User;

namespace KMA.APZRP2019.WalletSimulator.Providers.DB.EntityFramework
{
    public class WalletDBContext:DbContext
    {
        public WalletDBContext() : base("DB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WalletDBContext, Configuration>());
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
