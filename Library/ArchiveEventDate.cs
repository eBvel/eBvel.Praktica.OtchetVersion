namespace Library
{
    public class ArchiveEventDate
    {
        public int Id { get; set; }

        public virtual Calendar vCalendar { get; set; }

        public virtual ListofCases vListofCases { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
    }
}
