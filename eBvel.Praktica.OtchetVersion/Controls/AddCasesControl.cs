using System;
using System.Windows.Forms;
using Library;
using System.Data.Entity;
using eBvel.Praktica.OtchetVersion.Forms;
using System.IO;
using System.Linq;

namespace eBvel.Praktica.OtchetVersion.Controls
{
    public partial class AddCasesControl : UserControl
    {
        CalendarContext db;
        //
        //Метод, для поиска элемента в бд.
        //
        ListofCases SearchingObject()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false) return null;
                return db.DBListofCases.Find(id);
            }
            return null;
        }
        //
        //Конструктор.
        //
        public AddCasesControl()
        {
            InitializeComponent();
            db = new CalendarContext();
            db.DBListofCases.Load();
            dataGridView1.DataSource = db.DBListofCases.Local.ToBindingList();
        }
        //
        //Кнопка, добавляет дело в бд.
        //
        private void Add_Button_Click(object sender, EventArgs e)
        {
            var cases = new ListofCases();
            var addCasesForm = new AddCasesForm();
            DialogResult result = addCasesForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                try
                {
                    cases.NameEvent = addCasesForm.NameEvent_TextBox.Text;
                    cases.PlaceEvent = addCasesForm.PlaceEvent_TextBox.Text;
                    db.DBListofCases.Add(cases);
                    db.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Новое дело добавлено!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        //
        //Кнопка, удаляет дело из бд.
        //
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var cases = SearchingObject();
            db.DBListofCases.Remove(cases);
            db.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Дело удалено!", "Оповещение.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //
        //Выгрузка данных из таблицы в файл.
        //
        private void Unload_Button_Click(object sender, EventArgs e)
        {
            if (db.DBListofCases.Local.Count > 0)
            {
                using (var sw = new StreamWriter("CasesDate.txt", false))
                {
                    foreach (var item in db.DBListofCases)
                    {
                        sw.WriteLine(item.NameEvent);
                        sw.WriteLine(item.PlaceEvent);
                    }
                    MessageBox.Show("Выгрузка завершена!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        //
        //Загрузка данных из файла в бд.
        //
        private void Load_Button_Click(object sender, EventArgs e)
        {
            var cases = new ListofCases();
            using (var sr = new StreamReader("CasesDate.txt"))
            {
                while (!sr.EndOfStream)
                {
                    cases.NameEvent = sr.ReadLine();
                    cases.PlaceEvent = sr.ReadLine();
                    db.DBListofCases.Add(cases);
                    db.SaveChanges();
                }
            }
        }
        //
        //Кнопка, редактирования дела.
        //
        private void Edit_Button_Click(object sender, EventArgs e)
        {
            var cases = SearchingObject();
            var addCasesForm = new AddCasesForm();
            addCasesForm.NameEvent_TextBox.Text = cases.NameEvent;
            addCasesForm.PlaceEvent_TextBox.Text = cases.PlaceEvent;
            DialogResult result = addCasesForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                try
                {
                    cases.NameEvent = addCasesForm.NameEvent_TextBox.Text;
                    cases.PlaceEvent = addCasesForm.PlaceEvent_TextBox.Text;
                    db.DBListofCases.Add(cases);
                    db.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Дело изменено!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        //
        //Кнопка, поиска объекта в таблице.
        //
        private void Search_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.DBListofCases.Local.Where(p => p.NameEvent.Contains(textBox1.Text)).ToList();
        }
        private void SearchKeyPress_TextBox(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Search_Button.PerformClick();
        }
    }
}
