using System;
using System.Windows.Forms;

namespace Laba122
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void ShowResult(double x, double a, double y)
        {
            lblX.Text = $"x = {x:F4}";
            lblA.Text = $"a = {a:F4}";
            lblY.Text = $"y = {y:F6}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}