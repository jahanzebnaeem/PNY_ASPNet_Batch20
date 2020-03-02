namespace MVCModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updated_Countries_Table : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String());
        }
    }
}
