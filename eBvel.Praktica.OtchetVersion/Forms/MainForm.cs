﻿using eBvel.Praktica.OtchetVersion.Controls;
using System;
using System.Windows.Forms;

namespace eBvel.Praktica.OtchetVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Holidays_Menu_Click(object sender, EventArgs e)
        {
            var c = new AddHolidaysControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
        }

        private void Cases_Menu_Click(object sender, EventArgs e)
        {
            var c = new AddCasesControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
        }

        private void Event_Menu_Click(object sender, EventArgs e)
        {
            var c = new CreateEventControl();
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
    }
}
