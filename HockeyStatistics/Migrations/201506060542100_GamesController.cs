namespace HockeyStatistics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamesController : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Name = c.String(),
                        Win = c.Boolean(nullable: false),
                        Goals = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
