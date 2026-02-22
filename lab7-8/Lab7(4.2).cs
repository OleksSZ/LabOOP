using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Розрахунок шарового сегмента ===\n");

        double R = ReadPositiveDouble("Радіус сфери R: ");
        double H = ReadPositiveDouble("Висота сегмента H: ");

        if (H > 2 * R)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nПомилка: висота сегмента не може бути більшою за діаметр сфери (2R)!");
            Console.ResetColor();
            Console.WriteLine("\nНатисніть будь-яку клавішу...");
            Console.ReadKey();
            return;
        }

        // Обчислення
        double S_bok  = 2 * Math.PI * R * H;
        double S_osn  = Math.PI * H * (3 * R - H);
        double V      = Math.PI * H * H * (3 * R - H) / 3;

        // Вивід
        Console.WriteLine("РЕЗУЛЬТАТИ");
        Console.WriteLine("├───────────────────────────────┤");
        Console.WriteLine($"Бічна поверхня     Sбок  = {S_bok,10:F4}");
        Console.WriteLine($"Повна поверхня     Sповн = {S_osn,10:F4}");
        Console.WriteLine($"Об'єм сегмента         V = {V,10:F4}");


        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }

    static double ReadPositiveDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                return value;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Потрібне позитивне число!");
            Console.ResetColor();
        }
    }
}