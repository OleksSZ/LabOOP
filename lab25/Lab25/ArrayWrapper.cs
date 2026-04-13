using System;

namespace Lab25
{
    public class ArrayWrapper
    {
        private int[] arr;

        public ArrayWrapper(int size)
        {
            arr = new int[size];
        }

        // Індексатор для доступу до елементів
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        // Властивість для розміру масиву
        public int Length => arr.Length;

        // Метод для обчислення суми від’ємних елементів
        public int SumNegative()
        {
            int sum = 0;
            foreach (var val in arr)
            {
                if (val < 0) sum += val;
            }
            return sum;
        }

        // Для зручності – повернути масив як рядок
        public override string ToString()
        {
            return string.Join(" ", arr);
        }
    }
}
