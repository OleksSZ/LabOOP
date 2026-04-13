using System;
using System.Windows.Forms;

namespace Lab25
{
    public partial class Form1 : Form
    {
        private ArrayWrapper array;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            array = new ArrayWrapper(10); // масив на 10 елементів

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10); // випадкові числа від -10 до 9
            }

            txtArray.Text = array.ToString();
        }

        private void btnSumNeg_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Спочатку згенеруйте масив!");
                return;
            }

            int sum = array.SumNegative();
            txtResult.Text = $"Сума від’ємних елементів: {sum}";
        }
    }
}
