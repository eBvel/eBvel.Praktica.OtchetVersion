namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTimingMigration12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EventDates", "HolidaysId", "dbo.Holidays");
            DropIndex("dbo.EventDates", new[] { "HolidaysId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.EventDates", "HolidaysId");
            AddForeignKey("dbo.EventDates", "HolidaysId", "dbo.Holidays", "id", cascadeDelete: true);
        }
    }
}
