using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using eBvel.Praktica.OtchetVersion.Forms;
using System.Data.Entity;

namespace eBvel.Praktica.OtchetVersion.Controls
{
    public partial class StartPageControl : UserControl
    {
        CalendarContext db;
        public StartPageControl()
        {
            InitializeComponent();
            db = new CalendarContext();
            db.DBEventDate.Load();
        }

        private void Exit_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void References_Label_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

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

        private void Reference_Label1_Click(object sender, EventArgs e)
        {
            var printForm = new PrintForm();
            printForm.label1.Text = "СПРАВКА\r\nо запланированных мероприятиях на прошедший день";
            printForm.dataGridView1.DataSource = db.DBEventDate.Local.Where(p => p.vCalendar.ToString() == string.Format("{0:dd} {0:MMMM} {0:yyyy}", DateTime.Today.AddDays(-1))).ToList();
            MessageBox.Show(string.Format("{0:dd} {0:MMMM} {0:yyyy}", DateTime.Today.AddDays(-1)));
            DialogResult result = printForm.ShowDialog(this);
        }
    }
}
