namespace MVCModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Cities_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.Country_ID)
                .Index(t => t.Country_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Country_ID", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "Country_ID" });
            DropTable("dbo.Cities");
        }
    }
}
