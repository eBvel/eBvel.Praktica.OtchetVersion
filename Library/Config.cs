using System;

namespace Library
{
    public class Config
    {
        CalendarContext db;
        public event Action<EventDate, bool> ToDayIsEvent;

        public Config()
        {
            db = new CalendarContext();
        }

        public void CheckEventToDay()
        {
            foreach(var item in db.DBEventDate)
            {
                if(item.vCalendar.ToString() == string.Format("{0:dd} {0:MMMM} {0:yyyy}", DateTime.Today))
                {
                    ToDayIsEvent?.Invoke(item, true);
                    //break;
                }
                else if(DateTime.Parse(item.vCalendar.ToString()) < DateTime.Today && item.MarkEvent == false)
                {
                    ToDayIsEvent?.Invoke(item,false);

                }
            }
        }
    }
}
