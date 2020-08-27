namespace Library
{
    public class Holidays
    {
        public int id { get; set; }

        public int NumDay { get; set; }
        
        public string NameMonth { get; set; }

        public int NumYear { get; set; }

        public string FullDate => string.Format("{0:D2} {1:MMMM} {2:D4}",NumDay,NameMonth,NumYear);
    }
}
