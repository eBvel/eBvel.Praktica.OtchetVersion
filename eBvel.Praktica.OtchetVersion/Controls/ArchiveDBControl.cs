using System.Windows.Forms;
using Library;
using System.Data.Entity;
using System;
using System.Linq;
using eBvel.Praktica.OtchetVersion.Forms;

namespace eBvel.Praktica.OtchetVersion.Controls
{
    public partial class ArchiveDBControl : UserControl
    {
        CalendarContext db;
        //
        //Метод, для поиска объектов в бд.
        //
        ArchiveEventDate SearchingObject()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return null;
                return db.DBArchiveEvents.Find(id);
            }
            return null;
        }
        //
        //Конструктор.
        //
        public ArchiveDBControl()
        {
            InitializeComponent();
            db = new CalendarContext();
            db.DBArchiveEvents.Load();
            dataGridView1.DataSource = db.DBArchiveEvents.Local.ToBindingList();
        }
        //
        //Метод, загружает данные в combo box'ы.
        //
        void LoadDate_ComboBox(AddEventForm addEventForm)
        {
            addEventForm.comboBox2.DataSource = db.DBCalendars.ToList();
            addEventForm.comboBox2.ValueMember = "Id";
            addEventForm.comboBox2.DisplayMember = "CalendarFullDate";

            addEventForm.comboBox1.DataSource = db.DBListofCases.ToList();
            addEventForm.comboBox1.ValueMember = "Id";
            addEventForm.comboBox1.DisplayMember = "NameEvent";
        }
        //
        //Кнопка, переносит данные в основную таблицу.
        //
        private void Transfer_Button_Click(object sender, EventArgs e)
        {
            var archiveEvent = SearchingObject();
            var addEventForm = new AddEventForm();
            LoadDate_ComboBox(addEventForm);
            addEventForm.comboBox1.Text = archiveEvent.vCalendar.ToString();
            addEventForm.comboBox2.Text = archiveEvent.vListofCases.ToString();
            addEventForm.comboBox1.Enabled = false;
            addEventForm.dateTimePicker1.Value = Convert.ToDateTime(archiveEvent.StartTime);
            addEventForm.dateTimePicker2.Value = Convert.ToDateTime(archiveEvent.EndTime);
            DialogResult result = addEventForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                try
                {
                    var eventDate = new EventDate();
                    eventDate.vListofCases = (ListofCases)addEventForm.comboBox1.SelectedItem;
                    eventDate.vCalendar = (Calendar)addEventForm.comboBox2.SelectedItem;
                    eventDate.StartTime = addEventForm.dateTimePicker1.Value.ToShortTimeString();
                    eventDate.EndTime = addEventForm.dateTimePicker2.Value.ToShortTimeString();
                    eventDate.MarkEventSet();
                    db.DBEventDate.Add(eventDate);
                    db.DBArchiveEvents.Remove(archiveEvent);
                    db.SaveChanges();
                    MessageBox.Show("Объект восстановлен!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            dataGridView1.Refresh();
        }
        //
        //Кнопка, удаляет событие из архива.
        //
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var archiveEvent = SearchingObject();
            db.DBArchiveEvents.Remove(archiveEvent);
            db.SaveChanges();
            MessageBox.Show("Объект удален!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //
        //Кнопка, поиска объектов в списке.
        //
        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (Event_RadioButton.Checked)
                dataGridView1.DataSource = db.DBArchiveEvents.Local.Where(p => p.vListofCases.ToString().Contains(textBox1.Text)).ToList();
            else dataGridView1.DataSource = db.DBArchiveEvents.Local.Where(p => p.vCalendar.ToString().Contains(textBox1.Text)).ToList();
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Search_Button.PerformClick();
        }
    }
}
