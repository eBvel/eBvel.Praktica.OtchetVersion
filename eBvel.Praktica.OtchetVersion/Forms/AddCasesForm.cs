using System;
using System.Windows.Forms;

namespace eBvel.Praktica.OtchetVersion.Forms
{
    public partial class AddCasesForm : Form
    {
        public AddCasesForm()
        {
            InitializeComponent();
        }



        #region AnimationLabel
        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            NameEvent_TextBox.Focus();
        }


        private void NameEventTextBox_Leave(object sender, EventArgs e)
        {
            if (NameEvent_TextBox.Text == "")
                label2.Visible = true;
        }

        private void NameEventTextBox_Enter(object sender, EventArgs e)
        {
            label2_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            PlaceEvent_TextBox.Focus();
        }

        private void PlaceEventTextBox_Enter(object sender, EventArgs e)
        {
            label3_Click(sender, e);
        }

        private void PlaceEventTextBox_Leave(object sender, EventArgs e)
        {
            if (PlaceEvent_TextBox.Text == "")
                label3.Visible = true;
        }
        #endregion

    }
}
