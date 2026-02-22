// using System;

// namespace SequenceTasks
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.OutputEncoding = System.Text.Encoding.UTF8;
//             Console.InputEncoding = System.Text.Encoding.UTF8;

//             Console.WriteLine("=== Завдання з послідовністю чисел ===\n");

//             Console.Write("Введіть кількість чисел N: ");
//             if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
//             {
//                 Console.WriteLine("Помилка: N має бути цілим позитивним числом.");
//                 return;
//             }

//             // Генеруємо масив випадкових чисел
//             int[] numbers = new int[n];
//             Random rand = new Random();

//             Console.WriteLine("\nЗгенерована послідовність:");
//             for (int i = 0; i < n; i++)
//             {
//                 // діапазон можна змінити за бажанням
//                 numbers[i] = rand.Next(-50, 501);
//                 Console.Write(numbers[i] + "  ");
//                 if ((i + 1) % 10 == 0) Console.WriteLine();
//             }
//             Console.WriteLine("\n");


//             // 1. Сума чисел, що дорівнюють 5, у ПЕРШІЙ ПОЛОВИНІ (for)

//             int sumFiveFirstHalf = 0;
//             int half = n / 2;  //беремо тільки першу половину

//             for (int i = 0; i < half; i++)
//             {
//                 if (numbers[i] == 5)
//                 {
//                     sumFiveFirstHalf += 5;
//                 }
//             }

//             Console.WriteLine($"1. Сума чисел, що дорівнюють 5, у першій половині: {sumFiveFirstHalf}");
//             Console.WriteLine($"   (розглядалося перших {half} елементів)\n");

//             // 2. Сума непарних чисел > 100
            
//             int sumOddOver100 = 0;
//             int index = 0;

//             do
//             {
//                 if (numbers[index] > 100 && numbers[index] % 2 != 0)
//                 {
//                     sumOddOver100 += numbers[index];
//                 }
//                 index++;
//             }
//             while (index < n);

//             Console.WriteLine($"2. Сума непарних чисел, більших за 100: {sumOddOver100}");

//             Console.WriteLine("\nНатисніть Enter для завершення...");
//             Console.ReadLine();
//         }
//     }
// }

using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Завдання з послідовністю ===\n");

        Console.Write("N = ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Потрібне позитивне ціле число!");
            return;
        }

        int[] arr = new int[n];
        Random rnd = new Random();

        Console.WriteLine("\nПослідовність:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(-50, 501);
            Console.Write($"{arr[i],4}");
            if ((i + 1) % 10 == 0) Console.WriteLine();
        }
        Console.WriteLine("\n");

        // 1. Сума п'ятірок у першій половині
        int sum5 = 0;
        int half = n / 2;

        for (int i = 0; i < half; i++)
            if (arr[i] == 5) sum5 += 5;

        Console.WriteLine($"1. Сума чисел = 5 у першій половині: {sum5}  (перші {half} елементів)");

        // 2. Сума непарних > 100 (foreach — простіше та читабельніше)
        int sumOddBig = 0;
        foreach (int x in arr)
            if (x > 100 && x % 2 != 0)
                sumOddBig += x;

        Console.WriteLine($"2. Сума непарних чисел > 100:     {sumOddBig}");

        Console.WriteLine("\nНатисніть Enter...");
        Console.ReadLine();
    }
}