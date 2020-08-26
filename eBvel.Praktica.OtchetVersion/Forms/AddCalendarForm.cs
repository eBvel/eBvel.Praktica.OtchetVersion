using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace eBvel.Praktica.OtchetVersion.Forms
{
    public partial class AddCalendarForm : Form
    {
        public List<string> ListWeekEnd;
        public AddCalendarForm()
        {
            InitializeComponent();
            ListWeekEnd = new List<string>();
        }

        private void Panel1_Down(object sender, MouseEventArgs e)
        {
            if (panel1.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel1.BackColor = Color.White;
                Monday.ForeColor = Color.Black;
                ListWeekEnd.Add("Monday");
            }
            else
            {
                panel1.BackColor = Color.FromArgb(64, 64, 64);
                Monday.ForeColor = Color.White;
                ListWeekEnd.Remove("Monday");
            }
        }

        private void Panel2_Down(object sender, MouseEventArgs e)
        {
            if (panel2.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel2.BackColor = Color.White;
                Tuesday.ForeColor = Color.Black;
                ListWeekEnd.Add("Tuesday");
            }
            else
            {
                panel2.BackColor = Color.FromArgb(64, 64, 64);
                Tuesday.ForeColor = Color.White;
                ListWeekEnd.Remove("Tuesday");
            }
        }

        private void Panel3_Down(object sender, MouseEventArgs e)
        {
            if (panel3.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel3.BackColor = Color.White;
                Wednesday.ForeColor = Color.Black;
                ListWeekEnd.Add("Wednesday");
            }
            else
            {
                panel3.BackColor = Color.FromArgb(64, 64, 64);
                Wednesday.ForeColor = Color.White;
                ListWeekEnd.Remove("Wednesday");
            }
        }

        private void Panel4_Down(object sender, MouseEventArgs e)
        {
            if (panel4.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel4.BackColor = Color.White;
                Thursday.ForeColor = Color.Black;
                ListWeekEnd.Add("Thursday");
            }
            else
            {
                panel4.BackColor = Color.FromArgb(64, 64, 64);
                Thursday.ForeColor = Color.White;
                ListWeekEnd.Remove("Thursday");
            }
        }

        private void Panel5_Down(object sender, MouseEventArgs e)
        {
            if (panel5.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel5.BackColor = Color.White;
                Friday.ForeColor = Color.Black;
                ListWeekEnd.Add("Friday");
            }
            else
            {
                panel5.BackColor = Color.FromArgb(64, 64, 64);
                Friday.ForeColor = Color.White;
                ListWeekEnd.Remove("Friday");
            }
        }

        private void Panel6_Down(object sender, MouseEventArgs e)
        {
            if (panel6.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel6.BackColor = Color.White;
                Saturday.ForeColor = Color.Black;
                ListWeekEnd.Add("Saturday");
            }
            else
            {
                panel6.BackColor = Color.FromArgb(64, 64, 64);
                Saturday.ForeColor = Color.White;
                ListWeekEnd.Remove("Saturday");
            }
        }

        private void Panel7_Down(object sender, MouseEventArgs e)
        {
            if (panel7.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel7.BackColor = Color.White;
                Sunday.ForeColor = Color.Black;
                ListWeekEnd.Add("Sunday");
            }
            else
            {
                panel7.BackColor = Color.FromArgb(64, 64, 64);
                Sunday.ForeColor = Color.White;
                ListWeekEnd.Remove("Sunday");
            }
        }

        private void lMonday_Down(object sender, MouseEventArgs e)
        {
            Panel1_Down(sender, e);
        }

        private void lTuesday_Down(object sender, MouseEventArgs e)
        {
            Panel2_Down(sender, e);
        }

        private void lWednesday_Down(object sender, MouseEventArgs e)
        {
            Panel3_Down(sender, e);
        }

        private void lThursday_Down(object sender, MouseEventArgs e)
        {
            Panel4_Down(sender, e);
        }

        private void lFriday_Down(object sender, MouseEventArgs e)
        {
            Panel5_Down(sender, e);
        }

        private void lSaturday_Down(object sender, MouseEventArgs e)
        {
            Panel6_Down(sender, e);
        }

        private void lSunday_Down(object sender, MouseEventArgs e)
        {
            Panel7_Down(sender, e);
        }

    }
}
