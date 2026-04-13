using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab19
{
    public partial class Form1 : Form
    {
        private int[] array;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            array = new int[15]; // наприклад, 15 елементів

            txtArray.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-5, 20); // випадкові числа
                txtArray.AppendText(array[i] + " ");
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Спочатку згенеруйте масив!");
                return;
            }

            // 1) кількість елементів, кратних 3 між мінімальним і максимальним
            int minIndex = Array.IndexOf(array, array.Min());
            int maxIndex = Array.IndexOf(array, array.Max());

            int start = Math.Min(minIndex, maxIndex) + 1;
            int end = Math.Max(minIndex, maxIndex);

            int countDiv3 = 0;
            for (int i = start; i < end; i++)
            {
                if (array[i] % 3 == 0) countDiv3++;
            }

            // 2) порядковий номер першого нуля
            int zeroIndex = Array.IndexOf(array, 0);
            // 3) сума елементів після першого нуля
            int sumAfterZero = 0;
            if (zeroIndex != -1 && zeroIndex < array.Length - 1)
            {
                for (int i = zeroIndex + 1; i < array.Length; i++)
                {
                    sumAfterZero += array[i];
                }
            }

            txtResult.Text = $"Кількість кратних 3 між min і max: {countDiv3}\n" +
                             $"Індекс першого нуля: {zeroIndex}\n" +
                             $"Сума після першого нуля: {sumAfterZero}";
        }
    }
}
