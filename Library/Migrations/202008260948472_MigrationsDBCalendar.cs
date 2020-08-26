namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationsDBCalendar : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EventDates", "HolidaysId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventDates", "HolidaysId", c => c.Int(nullable: false));
        }
    }
}
