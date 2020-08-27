namespace Library
{
    public class EventDate
    {
        public int Id { get; set; }
        public int ListofCasesId { get; set; }
        public int CalendarId { get; set; }

        public virtual ListofCases vListofCases { get; set; }
        public virtual Calendar vCalendar { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public bool MarkEvent { get; private set; }

        public void MarkEventSet()
        {
            MarkEvent = false;
        }

        public bool MarkEventUnset()
        {
            if(MarkEvent == false)
            {
                MarkEvent = true;
                return true;
            }
            return false;
        }
    }
}
