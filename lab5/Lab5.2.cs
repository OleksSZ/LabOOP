// using System;

// namespace PiecewiseFunction
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.OutputEncoding = System.Text.Encoding.UTF8;
//             Console.InputEncoding = System.Text.Encoding.UTF8;

//             Console.WriteLine("Обчислення кусочно визначеної функції");
//             Console.WriteLine("y = { x³√(x - a)        якщо x > a");
//             Console.WriteLine("    { x · sin(a·x)      якщо x = a");
//             Console.WriteLine("    { e^(-x) · cos(a·x) якщо x < a");

//             double a = ReadDouble("Введіть значення параметра a: ");

//             Console.WriteLine("\nВведіть значення x (або введіть 'q' для завершення)\n");

//             while (true)
//             {
//                 string input = Console.ReadLine()?.Trim();

//                 if (input?.ToLower() == "q" || input?.ToLower() == "вихід" || string.IsNullOrEmpty(input))
//                 {
//                     Console.WriteLine("Завершення програми.");
//                     break;
//                 }

//                 if (!double.TryParse(input, out double x))
//                 {
//                     Console.ForegroundColor = ConsoleColor.Yellow;
//                     Console.WriteLine("Помилка: введіть число або 'q' для виходу.");
//                     Console.ResetColor();
//                     continue;
//                 }

//                 double y = CalculateY(x, a);

//                 Console.WriteLine($"x = {x,10:F4}   →   y = {y,12:F6}");
//                 Console.WriteLine(new string('-', 38));
//             }

//             Console.WriteLine("\nНатисніть Enter для завершення...");
//             Console.ReadLine();
//         }

//         static double CalculateY(double x, double a)
//         {
//             if (x > a)
//             {
//                 // x³ √(x - a)
//                 double root = Math.Sqrt(x - a);
//                 return Math.Pow(x, 3) * root;
//             }
//             else if (Math.Abs(x - a) < 1e-10) // для уникнення проблем з плаваючою точкою
//             {
//                 // x · sin(a·x)
//                 return x * Math.Sin(a * x);
//             }
//             else // x < a
//             {
//                 // e^(-x) · cos(a·x)
//                 return Math.Exp(-x) * Math.Cos(a * x);
//             }
//         }

//         static double ReadDouble(string prompt)
//         {
//             while (true)
//             {
//                 Console.Write(prompt);
//                 if (double.TryParse(Console.ReadLine(), out double value))
//                 {
//                     return value;
//                 }
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//                 Console.WriteLine("Будь ласка, введіть коректне число.");
//                 Console.ResetColor();
//             }
//         }
//     }
// }


using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;//це я просто кодування змінив щоб формули та язик краще були видні 

        Console.WriteLine("Кусочно визначена функція");
        Console.WriteLine("y = { x³ √(x - a)     якщо x > a");
        Console.WriteLine("    { x · sin(a·x)    якщо x = a");
        Console.WriteLine("    { e^(-x) cos(a·x) якщо x < a\n");

        double a = ReadDouble("a = ");

        Console.WriteLine("\nВведіть x (або 'q' / 'вихід' для завершення)\n");

        while (true)
        {
            Console.Write("x = ");
            string s = Console.ReadLine()?.Trim().ToLower();

            if (s == "q" || s == "вихід" || string.IsNullOrEmpty(s))
            {
                Console.WriteLine("\nДо побачення!");
                break;
            }

            if (!double.TryParse(s, out double x))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Потрібне число або 'q'");
                Console.ResetColor();
                continue;
            }

            double y = x > a ? Math.Pow(x, 3) * Math.Sqrt(x - a) :
                       Math.Abs(x - a) < 1e-9 ? x * Math.Sin(a * x) :
                       Math.Exp(-x) * Math.Cos(a * x);

            Console.WriteLine($"  →  y = {y,12:F6}\n" + new string('─', 32));
        }

        Console.WriteLine("Натисніть Enter...");
        Console.ReadLine();
    }

    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double val))
                return val;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введіть число");
            Console.ResetColor();
        }
    }
}