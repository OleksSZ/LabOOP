using System;
using System.Windows.Forms;

namespace Laba122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double a = double.Parse(txtA.Text);

                double y;

                if (x > a)
                {
                    // кубічний корінь з (x³ - a)
                    y = Math.Pow(x * x * x - a, 1.0 / 3.0);
                }
                else if (Math.Abs(x - a) < 1e-10)  // наближено x == a
                {
                    y = x * Math.Sin(a * x);
                }
                else  // x < a
                {
                    y = Math.Exp(-x) * Math.Cos(a * x);
                }

                // відкриваємо друге вікно з результатом
                Form2 resultForm = new Form2();
                resultForm.ShowResult(x, a, y);
                resultForm.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть коректні числа в обидва поля!", "Помилка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}