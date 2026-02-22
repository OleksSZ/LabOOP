using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Перевірка точки в області ===\n");
        Console.WriteLine("1  Чверть кола зліва зверху + прямокутник справа");
        Console.WriteLine("2  Півколо знизу + прямокутник зверху");
        Console.WriteLine("3  Півколо праворуч + прямокутник зліва знизу");
        Console.WriteLine();

        int variant = 0;
        try
        {
            variant = ReadInt("Виберіть варіант (1-3): ", 1, 3);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Помилка при виборі варіанту: " + ex.Message);
            Console.ResetColor();
            Console.WriteLine("\nПрограма завершена.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine();

        double r = 0, h = 0, l = 0;

        try
        {
            r = ReadPositive("R = ");
            h = ReadPositive("H = ");

            if (variant == 1)
            {
                l = ReadPositive("L = ");
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Помилка при введенні параметрів: " + ex.Message);
            Console.ResetColor();
            Console.WriteLine("\nНатисніть Enter...");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("\nВведіть координати точки:");

        double x = 0, y = 0;

        try
        {
            x = ReadDouble("x = ");
            y = ReadDouble("y = ");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Помилка при введенні координат: " + ex.Message);
            Console.ResetColor();
            Console.WriteLine("\nНатисніть Enter...");
            Console.ReadLine();
            return;
        }


        bool inside = false;

        if (variant == 1)
        {
            inside = IsInVariant1(x, y, r, h, l);
        }
        else if (variant == 2)
        {
            inside = IsInVariant2(x, y, r, h);
        }
        else if (variant == 3)
        {
            inside = IsInVariant3(x, y, r, h);
        }
        else
        {
            Console.WriteLine("Невідомий варіант (неможливо за умовою)");
        }

        Console.WriteLine("\n" + new string('═', 40));

        if (inside)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    ТАК, точка в області ✓");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    НІ, точка поза областю ✗");
        }

        Console.ResetColor();

        Console.WriteLine("\nНатисніть Enter...");
        Console.ReadLine();
    }


    static bool IsInVariant1(double x, double y, double r, double h, double l)
    {
        if (x <= 0)
        {
            return (x * x + y * y <= r * r) && (y >= 0);
        }
        else
        {
            return (x <= l) && (y >= 0) && (y <= h);
        }
    }

    static bool IsInVariant2(double x, double y, double r, double h)
    {
        if (y <= 0)
        {
            return x * x + y * y <= r * r;
        }
        else
        {
            return (Math.Abs(x) <= r) && (y <= h);
        }
    }

    static bool IsInVariant3(double x, double y, double r, double h)
    {
        if (x >= 0)
        {
            return x * x + y * y <= r * r;
        }
        else
        {
            return (x >= -r) && (y >= -h) && (y <= 0);
        }
    }


    static int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            string line = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(line))
            {
                throw new FormatException("Введення порожнє");
            }

            if (int.TryParse(line, out int val) && val >= min && val <= max)
            {
                return val;
            }

            Console.WriteLine($"Потрібно ціле число від {min} до {max}");
        }
    }

    static double ReadPositive(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string line = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(line))
            {
                throw new FormatException("Введення порожнє");
            }

            if (double.TryParse(line, out double val) && val > 0)
            {
                return val;
            }

            Console.WriteLine("Потрібне позитивне число");
        }
    }

    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string line = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(line))
            {
                throw new FormatException("Введення порожнє");
            }

            if (double.TryParse(line, out double val))
            {
                return val;
            }

            Console.WriteLine("Введіть коректне число");
        }
    }
}

