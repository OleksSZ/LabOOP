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
                Console.Clear(); // опціонально — чистить консоль для зручності

                Console.WriteLine("\n--- МЕНЮ ---");
                Console.WriteLine("1 - Площа квадрата");
                Console.WriteLine("2 - Ділення двох чисел");
                Console.WriteLine("3 - Квадратний корінь числа");
                Console.WriteLine("0 - Вихід");
                Console.Write("Ваш вибір: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    throw new FormatException("Введено не число!");
                }

                switch (choice)
                {
                    case 1:
                        try
                        {
                            ExecuteSquare();
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nПомилка при обчисленні площі квадрата:");
                            Console.WriteLine("  " + ex.Message);
                            Console.ResetColor();
                        }
                        break;

                    case 2:
                        try
                        {
                            ExecuteDivision();
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nПомилка при діленні:");
                            Console.WriteLine("  " + ex.Message);
                            Console.ResetColor();
                        }
                        break;

                    case 3:
                        try
                        {
                            ExecuteSquareRoot();
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nПомилка при обчисленні квадратного кореня:");
                            Console.WriteLine("  " + ex.Message);
                            Console.ResetColor();
                        }
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
                Console.WriteLine("\nПомилка в меню: " + ex.Message);
                Console.ResetColor();
            }

            if (!exit)
            {
                Console.WriteLine("\nНатисніть Enter, щоб продовжити...");
                Console.ReadLine();
            }
        }

        Console.WriteLine("\nДо побачення!");
    }


    static void ExecuteSquare()
    {
        Console.Write("Введіть довжину сторони квадрата: ");
        double side = double.Parse(Console.ReadLine()!);

        if (side <= 0)
        {
            throw new ArgumentException("Сторона квадрата повинна бути позитивною!");
        }

        double area = side * side;
        Console.WriteLine($"Площа квадрата: {area:F2}");
    }


    static void ExecuteDivision()
    {
        Console.Write("Введіть перше число: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Введіть друге число: ");
        double b = double.Parse(Console.ReadLine()!);

        if (Math.Abs(b) < 1e-10)
        {
            throw new DivideByZeroException("Ділення на нуль заборонено!");
        }

        double result = a / b;
        Console.WriteLine($"Результат: {result:F6}");
    }


    static void ExecuteSquareRoot()
    {
        Console.Write("Введіть число: ");
        double num = double.Parse(Console.ReadLine()!);

        if (num < 0)
        {
            throw new ArgumentException("Не можна взяти квадратний корінь з від'ємного числа!");
        }

        double result = Math.Sqrt(num);
        Console.WriteLine($"√{num} = {result:F6}");
    }
}