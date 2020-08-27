using System;
using System.Windows.Forms;
using eBvel.Praktica.OtchetVersion.Forms;
using Library;
using System.Data.Entity;
using System.Linq;

namespace eBvel.Praktica.OtchetVersion.Controls
{
    public partial class AddHolidaysControl : UserControl
    {
        CalendarContext db;
        //
        //Метод, для поиска объекта.
        //
        Holidays SearchingObject()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return null;
                return db.DBHolidays.Find(id);
            }
            return null;
        }
        //
        //Конструктор.
        //
        public AddHolidaysControl()
        {
            InitializeComponent();
            db = new CalendarContext();
            db.DBHolidays.Load();
            dataGridView1.DataSource = db.DBHolidays.Local.ToBindingList();
        }
        //
        //Кнопка, добавляет список выходных.
        //
        private void Add_Button_Click(object sender, EventArgs e)
        {
            var holiday = new Holidays();
            var addHDForm = new AddHolidaysForm();
            DialogResult result = addHDForm.ShowDialog(this);

            try
            {
                if (result == DialogResult.OK)
                {
                    foreach (var item in addHDForm.listBox1.Items)
                    {
                        DateTime date = Convert.ToDateTime(item);
                        holiday.NumDay = date.Day;
                        holiday.NameMonth = String.Format("{0:MMMM}", date);
                        holiday.NumYear = date.Year;
                        db.DBHolidays.Add(holiday);
                        db.SaveChanges();
                    }
                    dataGridView1.Refresh();
                    MessageBox.Show("Даты добавлены!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source,MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        //Кнопка, удаляет объект.
        //
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var holiday = SearchingObject() ?? throw new NullReferenceException("Для удаления, требуется выбрать дату!");
            db.DBHolidays.Remove(holiday);
            db.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Дата удалена!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //
        //Кнопка, поиска.
        //
        private void Search_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.DBHolidays.Local.Where(p => p.FullDate.Contains(textBox1.Text)).ToList();
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Search_Button.PerformClick();
        }
    }
}
