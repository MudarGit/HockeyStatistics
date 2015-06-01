namespace HockeyStatistics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statsController : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        Rank = c.Int(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GamesPlayed = c.Double(nullable: false),
                        Goals = c.Double(nullable: false),
                        Wins = c.Double(nullable: false),
                        Losses = c.Double(nullable: false),
                        WinPercentage = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Rank);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stats");
        }
    }
}
