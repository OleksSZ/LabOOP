using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Вспомогательная функция — берёт числа из текстовых полей
        private bool TryGetNumbers(out double a, out double b)
        {
            a = 0;
            b = 0;

            if (!double.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("В первом поле должно быть число!");
                return false;
            }

            if (!double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Во втором поле должно быть число!");
                return false;
            }

            return true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double a, out double b))
            {
                lblResult.Text = (a + b).ToString();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double a, out double b))
            {
                lblResult.Text = (a - b).ToString();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double a, out double b))
            {
                lblResult.Text = (a * b).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lblResult.Text = "0";
        }
    }
}