using System;
using System.Windows.Forms;

namespace eBvel.Praktica.OtchetVersion.Forms
{
    public partial class AddHolidaysForm : Form
    {
        bool checkbox = false;
        public AddHolidaysForm()
        {
            InitializeComponent();
        }
        //
        //Кнопка, добавляет даты в список.
        //
        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!checkbox)
            {
                DateTime date = dateTimePicker1.Value;
                listBox1.Items.Add(date);
            }
            else
            {
                var c = dateTimePicker2.Value - dateTimePicker1.Value;
                for (int i = 0; i < c.Days + 1; i++)
                {
                    DateTime date = dateTimePicker1.Value.AddDays(i);
                    listBox1.Items.Add(date.ToShortDateString());
                }
            }
        }
        //
        //Включение и выключение периода.
        //
        private void Period_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Period_CheckBox.Checked)
            {
                dateTimePicker2.Enabled = true;
                checkbox = true;
            }
            else { dateTimePicker2.Enabled = false; checkbox = false; }
        }
        //
        //Кнопка, удаляет выбранную дату.
        //
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int index = listBox1.SelectedIndex;
                if (index == -1) return;
                listBox1.Items.RemoveAt(index);
            }
            else MessageBox.Show("Список пуст!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
