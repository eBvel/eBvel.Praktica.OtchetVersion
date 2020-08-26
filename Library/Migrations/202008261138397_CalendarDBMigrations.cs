namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarDBMigrations : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ArchiveEventDates", "MarkEvent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ArchiveEventDates", "MarkEvent", c => c.Boolean(nullable: false));
        }
    }
}
