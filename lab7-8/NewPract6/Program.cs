using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Завдання з послідовністю чисел ===\n");

        try
        {

            int n = ReadPositiveInt("N = ");

            int[] numbers;

            try
            {

                numbers = GenerateAndPrintSequence(n);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка при генерації послідовності:");
                Console.WriteLine("  " + ex.Message);
                Console.ResetColor();
                return;
            }

            // Обчислення 1 — сума п'ятірок у першій половині
            int sumFives = CalculateSumOfFivesInFirstHalf(numbers);
            Console.WriteLine($"\n1. Сума чисел = 5 у першій половині: {sumFives}");

            // Обчислення 2 — сума непарних > 100
            int sumOddLarge = CalculateSumOfOddGreaterThan100(numbers);
            Console.WriteLine($"2. Сума непарних чисел > 100:        {sumOddLarge}");

            Console.WriteLine("\nПрограма завершена успішно.");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nНепередбачена помилка:");
            Console.WriteLine("  " + ex.GetType().Name + ": " + ex.Message);
            Console.ResetColor();
        }

        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }


    static int ReadPositiveInt(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(input))
        {
            throw new FormatException("Введення не може бути порожнім");
        }

        if (!int.TryParse(input, out int value))
        {
            throw new FormatException("Введено некоректне число");
        }

        if (value < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(value), value, "Кількість елементів повинна бути ≥ 1");
        }

        return value;
    }

    static int[] GenerateAndPrintSequence(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n), n, "Розмір масиву повинен бути позитивним");
        }

        int[] arr = new int[n];
        Random rnd = new Random();

        Console.WriteLine("\nЗгенерована послідовність:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(-50, 501);
            Console.Write($"{arr[i],5}");

            if ((i + 1) % 10 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();

        return arr;
    }


    static int CalculateSumOfFivesInFirstHalf(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return 0;

        int sum = 0;
        int half = arr.Length / 2;

        for (int i = 0; i < half; i++)
        {
            if (arr[i] == 5)
                sum += 5;
        }

        Console.WriteLine($"   (розглядалося перших {half} елементів)");
        return sum;
    }


    static int CalculateSumOfOddGreaterThan100(int[] arr)
    {
        if (arr == null)
            return 0;

        int sum = 0;

        foreach (int num in arr)
        {
            if (num > 100 && num % 2 != 0)
            {
                sum += num;
            }
        }

        return sum;
    }
}