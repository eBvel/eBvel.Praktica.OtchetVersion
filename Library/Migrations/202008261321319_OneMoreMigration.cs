namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneMoreMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArchiveEventDates", "vCalendar_Id", c => c.Int());
            AddColumn("dbo.ArchiveEventDates", "vListofCases_Id", c => c.Int());
            CreateIndex("dbo.ArchiveEventDates", "vCalendar_Id");
            CreateIndex("dbo.ArchiveEventDates", "vListofCases_Id");
            AddForeignKey("dbo.ArchiveEventDates", "vCalendar_Id", "dbo.Calendars", "Id");
            AddForeignKey("dbo.ArchiveEventDates", "vListofCases_Id", "dbo.ListofCases", "Id");
            DropColumn("dbo.ArchiveEventDates", "FullDate");
            DropColumn("dbo.ArchiveEventDates", "NameEvent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ArchiveEventDates", "NameEvent", c => c.String());
            AddColumn("dbo.ArchiveEventDates", "FullDate", c => c.String());
            DropForeignKey("dbo.ArchiveEventDates", "vListofCases_Id", "dbo.ListofCases");
            DropForeignKey("dbo.ArchiveEventDates", "vCalendar_Id", "dbo.Calendars");
            DropIndex("dbo.ArchiveEventDates", new[] { "vListofCases_Id" });
            DropIndex("dbo.ArchiveEventDates", new[] { "vCalendar_Id" });
            DropColumn("dbo.ArchiveEventDates", "vListofCases_Id");
            DropColumn("dbo.ArchiveEventDates", "vCalendar_Id");
        }
    }
}
