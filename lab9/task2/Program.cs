using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Console.InputEncoding = Encoding.UTF8;

        bool exit = false;

        while (!exit)
        {
            try
            {
                Console.WriteLine("\n--- МЕНЮ ---");
                Console.WriteLine("1 - Площа квадрата");
                Console.WriteLine("2 - Ділення двох чисел");
                Console.WriteLine("3 - Квадратний корінь числа");
                Console.WriteLine("0 - Вихід");
                Console.Write("Ваш вибір: ");

                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentException("Введення не може бути порожнім!");
                }

                if (!int.TryParse(input, out int choice))
                {
                    throw new FormatException("Введено некоректне число для вибору меню!");
                }

                switch (choice)
                {
                    case 1:
                        ExecuteSquare();
                        break;
                    case 2:
                        ExecuteDivision();
                        break;
                    case 3:
                        ExecuteSquareRoot();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        throw new ArgumentException("Невірний пункт меню!");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка: " + ex.Message);
                Console.ResetColor();
            }
        }

        Console.WriteLine("\nПрограма завершена. Натисніть будь-яку клавішу...");
        Console.ReadKey();
    }


    static void ExecuteSquare()
    {
        try
        {
            Console.Write("\nВведіть довжину сторони квадрата: ");
            double side = ReadPositiveDouble();

            double area = side * side;
            Console.WriteLine($"Площа: {area:F2}");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Помилка обчислення площі: " + ex.Message);
            Console.ResetColor();
        }
    }



    static void ExecuteDivision()
    {
        try
        {

            Console.Write("\nВведіть перше число: ");
            double num1 = ReadDouble();

            Console.Write("Введіть друге число: ");
            double num2 = ReadDouble();


            if (Math.Abs(num2) < 1e-10)
            {
                throw new DivideByZeroException("Ділення на нуль неможливе!");
            }

            double result = num1 / num2;
            Console.WriteLine($"Результат ділення: {result:F6}");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Помилка ділення: " + ex.Message);
            Console.ResetColor();
        }
    }



    static void ExecuteSquareRoot()
    {
        try
        {

            Console.Write("\nВведіть число для обчислення кореня: ");
            double num = ReadDouble();

            if (num < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(num), num, "Число повинно бути невід'ємним для квадратного кореня!");
            }

            double result = Math.Sqrt(num);
            Console.WriteLine($"Квадратний корінь: {result:F6}");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Помилка обчислення кореня: " + ex.Message);
            Console.ResetColor();
        }
    }


    static double ReadDouble()
    {
        string input = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Введення не може бути порожнім!");
        }

        if (!double.TryParse(input, out double value))
        {
            throw new FormatException("Введено некоректне число!");
        }

        return value;
    }



    static double ReadPositiveDouble()
    {
        double value = ReadDouble();

        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException("Число повинно бути позитивним!");
        }

        return value;
    }
}