namespace HockeyStatistics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamesAddGameNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "GameNumber", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "GameNumber");
        }
    }
}
