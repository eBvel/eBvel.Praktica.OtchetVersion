using eBvel.Praktica.OtchetVersion.Controls;
using System;
using System.Windows.Forms;

namespace eBvel.Praktica.OtchetVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var c = new StartPageControl();
            panel1.Controls.Add(c);
        }

        private void Holidays_Menu_Click(object sender, EventArgs e)
        {
            var c = new AddHolidaysControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
        }

        private void Calendar_Menu_Click(object sender, EventArgs e)
        {
            var c = new CreateCalendarControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
            c.HighlightHolidays();
        }

        private void Archive_Menu_Click(object sender, EventArgs e)
        {
            var c = new ArchiveDBControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
        }

        private void Setting_Menu_Click(object sender, EventArgs e)
        {
            var c = new StartPageControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
        }

        private void Help_Menu_Click(object sender, EventArgs e)
        {
            var c = new HelpControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
        }

        private void CasesList_Menu_Click(object sender, EventArgs e)
        {
            var c = new AddCasesControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
        }

        private void EventList_Menu_Click(object sender, EventArgs e)
        {
            var c = new CreateEventControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
            c.SecondConstruction();
        }
    }
}
