using System.Data.Entity.Migrations;

namespace KMA.APZRP2019.WalletSimulator.EntityFrameworkWrapper.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WalletDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WalletDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
