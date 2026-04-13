using System;

namespace Lab22
{
    internal class Program
    {
        static void Main()
        {
            MyQueue q1 = new MyQueue();
            q1.Enqueue(1); q1.Enqueue(3); q1.Enqueue(5); q1.Enqueue(8);

            MyQueue q2 = new MyQueue();
            q2.Enqueue(2); q2.Enqueue(4); q2.Enqueue(6);

            Console.WriteLine("=== МЕНЮ ===");
            Console.WriteLine("1. Вилучення до парного");
            Console.WriteLine("2. Об'єднання черг (чергування)");
            Console.WriteLine("3. Об'єднання черг (сортування)");
            Console.WriteLine("4. Масив у зворотному порядку");
            Console.WriteLine("5. Слово у зворотному порядку");
            Console.WriteLine("0. Вихід");

            while (true)
            {
                Console.Write("\nВаш вибір: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        q1.RemoveUntilEven();
                        q1.Print();
                        break;
                    case "2":
                        var mergedAlt = MyQueue.MergeAlternate(q1, q2);
                        mergedAlt.Print();
                        break;
                    case "3":
                        var mergedSorted = MyQueue.MergeSorted(q1, q2);
                        mergedSorted.Print();
                        break;
                    case "4":
                        int[] arr = { 1, 2, 3, 4, 5 };
                        MyStack.PrintArrayReverse(arr);
                        break;
                    case "5":
                        Console.Write("Введіть слово: ");
                        string word = Console.ReadLine();
                        MyStack.PrintWordReverse(word);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }
            }
        }
    }
}
