using System;
using System.Windows.Forms;
using eBvel.Praktica.OtchetVersion.Forms;
using Library;
using System.Data.Entity;

namespace eBvel.Praktica.OtchetVersion.Controls
{
    public partial class AddHolidaysControl : UserControl
    {
        CalendarContext db;

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

        public AddHolidaysControl()
        {
            InitializeComponent();
            db = new CalendarContext();
            db.DBHolidays.Load();
            dataGridView1.DataSource = db.DBHolidays.Local.ToBindingList();
        }

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

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var holiday = SearchingObject() ?? throw new NullReferenceException("Для удаления, требуется выбрать дату!");
            db.DBHolidays.Remove(holiday);
            db.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Дата удалена!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
