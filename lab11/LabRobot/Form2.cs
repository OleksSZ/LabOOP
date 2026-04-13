using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace LabRobot
{
    public partial class Form2 : Form
    {
        // [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Form1? MainForm { get; set; }

        public Form2()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        

        private void rbTextRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTextRed.Checked && MainForm != null) MainForm.SetTextColor(Color.Red);

            MainForm.;
        }

        private void rbTextGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTextGreen.Checked && MainForm != null) MainForm.SetTextColor(Color.Green);
        }

        private void rbTextYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTextYellow.Checked && MainForm != null) MainForm.SetTextColor(Color.Yellow);
        }

        private void rbTextBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTextBlue.Checked && MainForm != null) MainForm.SetTextColor(Color.Blue);
        }

        private void rbBackBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackBlue.Checked && MainForm != null) MainForm.SetBackColor(Color.Blue);
        }

        private void rbBackYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackYellow.Checked && MainForm != null) MainForm.SetBackColor(Color.Yellow);
        }

        private void rbBackGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackGreen.Checked && MainForm != null) MainForm.SetBackColor(Color.Green);
        }

        private void rbBackRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackRed.Checked && MainForm != null) MainForm.SetBackColor(Color.Red);
        }
    }
}