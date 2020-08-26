namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimingMigrations2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EventDates", "StartTime", c => c.String());
            AlterColumn("dbo.EventDates", "EndTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EventDates", "EndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EventDates", "StartTime", c => c.DateTime(nullable: false));
        }
    }
}
