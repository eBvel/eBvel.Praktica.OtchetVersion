using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Library;
using eBvel.Praktica.OtchetVersion.Forms;
using System.Data.Entity;

namespace eBvel.Praktica.OtchetVersion.Controls
{
    public partial class StartPageControl : UserControl
    {
        CalendarContext db;
        //
        //Конструктор.
        //
        public StartPageControl()
        {
            InitializeComponent();
            db = new CalendarContext();
            db.DBEventDate.Load();
        }
        //
        //Кнопка, выход.
        //
        private void Exit_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //Кнопка, отображает список справок.
        //
        private void References_Label_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        //
        //Кнопка, отображает список отчетов.
        //
        private void Reports_Label_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        #region Button's Animation
        private void Reference_MouseEnter(object sender, EventArgs e)
        {
            References_Label.ForeColor = Color.DarkSlateGray;
        }

        private void Reference_MouseLeave(object sender, EventArgs e)
        {
            References_Label.ForeColor = Color.White;
        }

        private void Report_MouseEnter(object sender, EventArgs e)
        {
            Reports_Label.ForeColor = Color.DarkSlateGray;
        }

        private void Report_MouseLeave(object sender, EventArgs e)
        {
            Reports_Label.ForeColor = Color.White;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit_Label.ForeColor = Color.DarkSlateGray;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit_Label.ForeColor = Color.White;
        }
        #endregion

        #region Output document
        private void Reference_Label1_Click(object sender, EventArgs e)
        {
            var printForm = new PrintForm();
            printForm.label1.Text = "СПРАВКА\r\nо запланированных мероприятиях на прошедший день";
            printForm.dataGridView1.DataSource = db.DBEventDate.Local.Where
                (p => p.vCalendar.ToString() == string.Format("{0:dd} {0:MMMM} {0:yyyy}", DateTime.Today.AddDays(-1))).ToList();
            DialogResult result = printForm.ShowDialog(this);
        }

        private void Reference_Label2_Click(object sender, EventArgs e)
        {
            var printForm = new PrintForm();
            printForm.label1.Text = "СПРАВКА\r\nо запланированных мероприятиях на текущий год";
            printForm.dataGridView1.DataSource = db.DBEventDate.Local.ToBindingList();
            DialogResult result = printForm.ShowDialog(this);
        }

        private void Report_Label1_Click(object sender, EventArgs e)
        {
            var printForm = new PrintForm();
            printForm.label1.Text = "ОТЧЕТ\r\nо запланированных мероприятиях на будущий день";
            printForm.dataGridView1.DataSource = db.DBEventDate.Local.Where
                (p => p.vCalendar.ToString() == string.Format("{0:dd} {0:MMMM} {0:yyyy}", DateTime.Today.AddDays(1))).ToList();
            DialogResult result = printForm.ShowDialog(this);
        }

        private void Report_Label2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            Continue_Button.Visible = true;
        }

        private void Continue_Button_Click(object sender, EventArgs e)
        {
            var firstDate = dateTimePicker1.Value;
            var secondDate = dateTimePicker2.Value;
            var printForm = new PrintForm();
            printForm.label1.Text = $"ОТЧЕТ\r\nо проведенных мероприятиях с {firstDate.Year} года по {secondDate.Year} года";
            printForm.dataGridView1.DataSource = db.DBEventDate.Local.Where
                (p => Convert.ToDateTime(p.vCalendar.ToString()) > firstDate && Convert.ToDateTime(p.vCalendar.ToString()) < secondDate).ToList();
            DialogResult result = printForm.ShowDialog(this);
        }
        #endregion
    }
}
