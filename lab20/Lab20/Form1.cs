using System;
using System.Windows.Forms;

namespace Lab20
{
    public partial class Form1 : Form
    {
        private int[,] array;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Створюємо масив 3x4 для прикладу
            array = new int[3, 4];
            Random rnd = new Random();

            txtArray.Clear();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                    txtArray.AppendText(array[i, j] + "\t");
                }
                txtArray.AppendText(Environment.NewLine);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Спочатку згенеруйте масив!");
                return;
            }

            // 1) кількість елементів, кратних 3
            int countDiv3 = 0;
            foreach (int val in array)
            {
                if (val % 3 == 0) countDiv3++;
            }

            // 2) порядковий номер максимального елемента
            int maxVal = array[0, 0];
            int index = 0;
            int pos = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxVal)
                    {
                        maxVal = array[i, j];
                        pos = index;
                    }
                    index++;
                }
            }

            // 3) сума елементів кожного рядка
            string rowSums = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                rowSums += $"Рядок {i + 1}: {sum}\n";
            }

            txtResult.Text = $"1)чисел кратних 3: {countDiv3}\n" +
                             $"2)Номер макс. елемента: {pos}\n" +
                             $"3)Суми рядків:\n{rowSums}";
        }
    }
}
