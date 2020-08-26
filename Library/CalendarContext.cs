namespace Library
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CalendarContext : DbContext
    {

        public CalendarContext()
            : base("name=CalendarConnection")
        {
        }
        public DbSet<Holidays> DBHolidays { get; set; }
        public DbSet<Calendar> DBCalendars { get; set; } 
        public DbSet<ListofCases> DBListofCases { get; set; }
        public DbSet<EventDate> DBEventDate { get; set; }
    }
}