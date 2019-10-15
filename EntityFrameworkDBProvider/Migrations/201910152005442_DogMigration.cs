namespace KMA.APZRP2019.WalletSimulator.EntityFrameworkWrapper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DogMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Psina",
                c => new
                    {
                        Aidishka = c.Guid(nullable: false),
                        Klikuha = c.String(nullable: false),
                        DogTypeID = c.Int(nullable: false),
                        DOB = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        OwnerGuid = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Aidishka)
                .ForeignKey("dbo.User", t => t.OwnerGuid, cascadeDelete: true)
                .Index(t => t.OwnerGuid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Psina", "OwnerGuid", "dbo.User");
            DropIndex("dbo.Psina", new[] { "OwnerGuid" });
            DropTable("dbo.Psina");
        }
    }
}
