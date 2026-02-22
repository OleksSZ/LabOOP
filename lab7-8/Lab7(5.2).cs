using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Кусочно визначена функція");
        Console.WriteLine("y = { x³ √(x - a)     якщо x > a");
        Console.WriteLine("    { x · sin(a·x)    якщо x = a");
        Console.WriteLine("    { e^(-x) cos(a·x) якщо x < a");
        Console.WriteLine(new string('─', 45));

        double a;

        try
        {
            a = ReadDouble("a = ");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Помилка при введенні a: " + ex.Message);
            Console.ResetColor();
            Console.WriteLine("\nПрограма завершена.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("\nВведіть x (або 'q' / 'вихід' для завершення)\n");

        while (true)
        {
            Console.Write("x = ");
            string input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("\nДо побачення!");
                break;
            }

            string s = input.ToLower();
            if (s == "q" || s == "вихід")
            {
                Console.WriteLine("\nДо побачення!");
                break;
            }

            double x;
            try
            {
                x = double.Parse(input);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Помилка: потрібно ввести число або 'q'");
                Console.ResetColor();
                continue;
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Число занадто велике або занадто мале");
                Console.ResetColor();
                continue;
            }

            double y;

            if (x > a)
            {
                // x³ √(x - a)
                double diff = x - a;
                if (diff < 0)   // теоретично не повинно бути, але для безпеки
                {
                    throw new InvalidOperationException("x > a, але x - a < 0 (математична помилка)");
                }
                y = Math.Pow(x, 3) * Math.Sqrt(diff);
            }
            else if (Math.Abs(x - a) < 1e-9)
            {
                y = x * Math.Sin(a * x);
            }
            else   // x < a
            {
                y = Math.Exp(-x) * Math.Cos(a * x);
            }

            Console.WriteLine($"  →  y = {y,12:F6}");
            Console.WriteLine(new string('─', 32));
        }

        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
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

            if (double.TryParse(line, out double value))
            {
                return value;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Помилка: введіть коректне число");
            Console.ResetColor();
        }
    }
}