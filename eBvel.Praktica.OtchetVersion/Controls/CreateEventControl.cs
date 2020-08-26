using System;
using System.Linq;
using System.Windows.Forms;
using Library;
using System.Data.Entity;
using eBvel.Praktica.OtchetVersion.Forms;

namespace eBvel.Praktica.OtchetVersion.Controls
{
    public partial class CreateEventControl : UserControl
    {
        CalendarContext db;
        //
        //Метод, для поиска объектов в бд.
        //
        EventDate SearchingObject()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return null;
                return db.DBEventDate.Find(id);
            }
            return null;
        }
        //
        //Конструктор.
        //
        public CreateEventControl()
        {
            InitializeComponent();
            db = new CalendarContext();
            db.DBEventDate.Load();
            dataGridView1.DataSource = db.DBEventDate.Local.ToBindingList();
        }
        //
        //Кнопка, добавляет новый элемент в бд.
        //
        private void Add_Button_Click(object sender, EventArgs e)
        {
            var eventDate = new EventDate();
            var addEventForm = new AddEventForm();

            addEventForm.comboBox1.DataSource = db.DBCalendars.ToList();
            addEventForm.comboBox1.ValueMember = "Id";
            addEventForm.comboBox1.DisplayMember = "CalendarFullDate";

            addEventForm.comboBox2.DataSource = db.DBListofCases.ToList();
            addEventForm.comboBox2.ValueMember = "Id";
            addEventForm.comboBox2.DisplayMember = "NameEvent";

            DialogResult result = addEventForm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                try
                {
                    eventDate.vCalendar = (Calendar)addEventForm.comboBox1.SelectedItem;
                    eventDate.vListofCases = (ListofCases)addEventForm.comboBox2.SelectedItem;
                    eventDate.StartTime = addEventForm.dateTimePicker1.Value.ToShortTimeString();
                    eventDate.EndTime = addEventForm.dateTimePicker2.Value.ToShortTimeString();
                    eventDate.MarkEventSet();
                    db.DBEventDate.Add(eventDate);
                    db.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Событие добавлено!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var eventDate = SearchingObject();
            var CheckMark = eventDate.MarkEventUnset();
            if (CheckMark == true)
                MessageBox.Show("Мероприятие проведено!");
            else MessageBox.Show("Мероприятие уже было проведено!");
        }
    }
}
