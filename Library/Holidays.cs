using System;
using System.Collections.Generic;

namespace Library
{
    public class Holidays
    {
        public Holidays()
        {
            Events = new List<EventDate>();
        }

        public override string ToString()
        {
            return FullDate;
        }

        public int id { get; set; }

        public int NumDay { get; set; }
        
        public string NameMonth { get; set; }

        public int NumYear { get; set; }

        public string FullDate => String.Format("{0:D2} {1:MMMM} {2:D4}",NumDay,NameMonth,NumYear);
        //public string ShortFullDate => string.Format("{0:D2}.{1:MM}.{2:D4}", NumDay, NameMonth, NumYear);

        public virtual ICollection<EventDate> Events { get; set; }
    }
}
