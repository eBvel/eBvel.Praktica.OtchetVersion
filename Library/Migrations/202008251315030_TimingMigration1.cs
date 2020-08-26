namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimingMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventDates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HolidaysId = c.Int(nullable: false),
                        ListofCasesId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        MarkEvent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Holidays", t => t.HolidaysId, cascadeDelete: true)
                .ForeignKey("dbo.ListofCases", t => t.ListofCasesId, cascadeDelete: true)
                .Index(t => t.HolidaysId)
                .Index(t => t.ListofCasesId);
            
            CreateTable(
                "dbo.Holidays",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NumDay = c.Int(nullable: false),
                        NameMonth = c.String(),
                        NumYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ListofCases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameEvent = c.String(),
                        PlaceEvent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventDates", "ListofCasesId", "dbo.ListofCases");
            DropForeignKey("dbo.EventDates", "HolidaysId", "dbo.Holidays");
            DropIndex("dbo.EventDates", new[] { "ListofCasesId" });
            DropIndex("dbo.EventDates", new[] { "HolidaysId" });
            DropTable("dbo.ListofCases");
            DropTable("dbo.Holidays");
            DropTable("dbo.EventDates");
        }
    }
}
