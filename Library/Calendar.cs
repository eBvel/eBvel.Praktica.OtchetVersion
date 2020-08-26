using System;
using System.Collections.Generic;

namespace Library
{
    public class Calendar
    {
        public Calendar()
        {
            EventDates = new List<EventDate>();
        }

        public override string ToString()
        {
            return CalendarFullDate;
        }

        public int Id { get; set; }

        public int NumDay { get; set; }

        public string NameMonth { get; set; }

        public int NumYear { get; set; }

        public string Typeofday { get; set; }

        public string CalendarFullDate => String.Format("{0:D2} {1:MMMM} {2:D4}", NumDay, NameMonth, NumYear);

        public virtual ICollection<EventDate> EventDates { get; set; }
    }
}
