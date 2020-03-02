namespace MVCModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Countries_Cities_Relationship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "Country_ID", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "Country_ID" });
            RenameColumn(table: "dbo.Cities", name: "Country_ID", newName: "CountryID");
            AlterColumn("dbo.Cities", "CountryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "CountryID");
            AddForeignKey("dbo.Cities", "CountryID", "dbo.Countries", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CountryID", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "CountryID" });
            AlterColumn("dbo.Cities", "CountryID", c => c.Int());
            RenameColumn(table: "dbo.Cities", name: "CountryID", newName: "Country_ID");
            CreateIndex("dbo.Cities", "Country_ID");
            AddForeignKey("dbo.Cities", "Country_ID", "dbo.Countries", "ID");
        }
    }
}
