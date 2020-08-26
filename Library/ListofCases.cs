using System.Collections.Generic;

namespace Library
{
    public class ListofCases
    {
        public ListofCases()
        {
            Events = new List<EventDate>();
        }

        public override string ToString()
        {
            
            return ReturnEvent;
        }

        public int Id { get; set; }
        
        public string NameEvent { get; set; }

        public string PlaceEvent { get; set; }

        public string ReturnEvent => NameEvent + $"\r\nМесто проведения: {PlaceEvent}";

        public virtual ICollection<EventDate> Events { get; set; }
    }
}
