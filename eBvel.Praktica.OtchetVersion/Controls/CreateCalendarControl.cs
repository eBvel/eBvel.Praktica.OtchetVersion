using System;
using System.Windows.Forms;
using Library;
using System.Data.Entity;
using eBvel.Praktica.OtchetVersion.Forms;

namespace eBvel.Praktica.OtchetVersion.Controls
{
    public partial class CreateCalendarControl : UserControl
    {
        CalendarContext db;
        const int period = 365;
        //
        //Метод, для поиска объектов в бд.
        //
        Calendar SearchingObject()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return null;
                return db.DBCalendars.Find(id);
            }
            return null;
        }
        //
        //Конструктор.
        //
        public CreateCalendarControl()
        {
            InitializeComponent();
            db = new CalendarContext();
            db.DBCalendars.Load();
            dataGridView1.DataSource = db.DBCalendars.Local.ToBindingList();
        }
        //
        //Кнопка, заполняет бд.
        //
        private void Create_Button_Click(object sender, EventArgs e)
        {
            var calendar = new Calendar();
            var addCalendarForm = new AddCalendarForm();
            var listHolidays = db.DBHolidays.ToString();
            DialogResult result = addCalendarForm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                try
                {
                    DateTime Startdate = addCalendarForm.dateTimePicker1.Value;
                    void AddCalendar(DateTime _date)
                    {
                        calendar.NumDay = _date.Day;
                        calendar.NameMonth = String.Format("{0:MMMM}", _date);
                        calendar.NumYear = _date.Year;
                    }
                    for (int i = 0; i < period; i++)
                    {
                        var date = Startdate.AddDays(i);
                        if (addCalendarForm.ListWeekEnd.Contains(date.DayOfWeek.ToString()) ||
                            listHolidays.Contains(date.ToLongDateString()))
                        {
                            AddCalendar(date);
                            calendar.Typeofday = "Выходной день";
                            db.DBCalendars.Add(calendar);
                        }
                        else
                        {
                            AddCalendar(date);
                            calendar.Typeofday = "Рабочий день";
                            db.DBCalendars.Add(calendar);
                        }
                        db.SaveChanges();
                    }
                    MessageBox.Show("Календарь создан!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        //
        //Кнопка, изменяет тип дня(Рабочий - Выходной).
        //
        private void Holiday_Button_Click(object sender, EventArgs e)
        {
            var calendar = SearchingObject();
            if (calendar.Typeofday == "Рабочий день")
                calendar.Typeofday = "Выходной день";
            else calendar.Typeofday = "Рабочий день";
            db.SaveChanges();
            dataGridView1.Refresh();
        }
    }
}
