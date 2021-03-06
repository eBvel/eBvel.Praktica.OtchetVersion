﻿using System;
using System.Windows.Forms;
using Library;
using System.Data.Entity;
using eBvel.Praktica.OtchetVersion.Forms;
using System.Linq;
using System.Drawing;

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
            CheckHolidays();
            dataGridView1.DataSource = db.DBCalendars.Local.ToBindingList();
        }
        //
        //Кнопка, заполняет бд.
        //
        private void Create_Button_Click(object sender, EventArgs e)
        {
            var calendar = new Calendar();
            var addCalendarForm = new AddCalendarForm();
            var listHolidays = db.DBHolidays.ToList().Select(p => p.FullDate);
            DialogResult result = addCalendarForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                try
                {
                    DateTime Startdate = addCalendarForm.dateTimePicker1.Value;

                    void AddCalendar(DateTime _date, byte k)
                    {
                        calendar.NumDay = _date.Day;
                        calendar.NameMonth = String.Format("{0:MMMM}", _date);
                        calendar.NumYear = _date.Year;
                        if (k == 1)
                            calendar.Typeofday = "Выходной день";
                        else calendar.Typeofday = "Рабочий день";
                        db.DBCalendars.Add(calendar);
                    }

                    for (int i = 0; i < period; i++)
                    {
                        var date = Startdate.AddDays(i);
                        if (addCalendarForm.ListWeekEnd.Contains(date.DayOfWeek.ToString()) ||
                            listHolidays.Contains(string.Format("{0:dd} {0:MMMM} {0:yyyy}", date)))
                        {
                            AddCalendar(date, 1);
                        }
                        else
                        {
                            AddCalendar(date, 0);
                        }
                        db.SaveChanges();
                    }
                    MessageBox.Show("Календарь создан!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
        //
        //Кнопка, поиска.
        //
        private void Search_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.DBCalendars.Local.Where(p => p.CalendarFullDate.Contains(textBox1.Text)).ToList();
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Search_Button.PerformClick();
        }
        //
        //Выделение выходных дней.
        //
        internal void HighlightHolidays()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Cells[5].Value.ToString() == "Выходной день")
                    {
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                }
            }
        }
        //
        //Метод, проверка списка праздничных дней.
        //
        void CheckHolidays()
        {
            var listHolidays = db.DBHolidays.ToList().Select(p => p.FullDate);
            foreach (var date in db.DBCalendars)
            {
                if (listHolidays.Contains(date.CalendarFullDate))
                {
                    date.Typeofday = "Выходной день";
                }
            }
            db.SaveChanges();
        }
    }
}
