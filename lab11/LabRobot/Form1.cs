using System;
using System.Windows.Forms;

namespace LabRobot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetTextColor(Color color)
        {
            label1.ForeColor = color;
            labelResult.ForeColor = color;
        }

        public void SetBackColor(Color color)
        {
            this.BackColor = color;
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MainForm = this;
            form2.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtX.Text, out double x) ||
                !double.TryParse(txtY.Text, out double y) ||
                !double.TryParse(txtZ.Text, out double z))
            {
                MessageBox.Show("Введіть коректні числа!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double res1 = Math.Sin(x) + Math.Cos(y) + z;
            double res2 = Math.Sin(2 * (x + y + z));
            double res3 = x + y * y + z * z * z;

            labelResult.Text =
                $"1) sin(x) + cos(y) + z = {res1:F4}\n" +
                $"2) sin(2·(x+y+z))     = {res2:F4}\n" +
                $"3) x + y² + z³         = {res3:F4}";
        }
    }
}