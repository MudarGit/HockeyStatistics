namespace HockeyStatistics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "AddGame", c => c.Boolean(nullable: false));
            DropColumn("dbo.Games", "GameNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "GameNumber", c => c.Double(nullable: false));
            DropColumn("dbo.Games", "AddGame");
        }
    }
}
