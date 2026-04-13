using System;
using System.Collections.Generic;

namespace Lab22
{
    public class MyQueue
    {
        private Queue<int> queue = new Queue<int>();

        public void Enqueue(int item) => queue.Enqueue(item);

        public void Print()
        {
            Console.WriteLine("Черга: " + string.Join(", ", queue));
        }

        // 1. Вилучення елементів до першого парного
        public void RemoveUntilEven()
        {
            while (queue.Count > 0 && queue.Peek() % 2 != 0)
            {
                queue.Dequeue();
            }
        }

        // 2. Об'єднання двох черг з чергуванням
        public static MyQueue MergeAlternate(MyQueue q1, MyQueue q2)
        {
            var result = new MyQueue();
            var arr1 = q1.queue.ToArray();
            var arr2 = q2.queue.ToArray();

            int maxLen = Math.Max(arr1.Length, arr2.Length);
            for (int i = 0; i < maxLen; i++)
            {
                if (i < arr1.Length) result.Enqueue(arr1[i]);
                if (i < arr2.Length) result.Enqueue(arr2[i]);
            }
            return result;
        }

        // 3. Об'єднання двох черг зі збереженням упорядкованості
        public static MyQueue MergeSorted(MyQueue q1, MyQueue q2)
        {
            var result = new MyQueue();
            var arr1 = new List<int>(q1.queue);
            var arr2 = new List<int>(q2.queue);

            int i = 0, j = 0;
            while (i < arr1.Count && j < arr2.Count)
            {
                if (arr1[i] <= arr2[j])
                {
                    result.Enqueue(arr1[i]);
                    i++;
                }
                else
                {
                    result.Enqueue(arr2[j]);
                    j++;
                }
            }
            while (i < arr1.Count) result.Enqueue(arr1[i++]);
            while (j < arr2.Count) result.Enqueue(arr2[j++]);

            return result;
        }
    }
}
