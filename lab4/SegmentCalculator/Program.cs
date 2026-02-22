using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Расчёт шарового сегмента ===\n");

        // Ввод данных
        Console.Write("Введите радиус сферы R: ");
        double R = double.Parse(Console.ReadLine());

        Console.Write("Введите высоту сегмента H: ");
        double H = double.Parse(Console.ReadLine());

        // Вычисления по формулам
        double S_bok = 2 * Math.PI * R * H;
        double S_poln = Math.PI * H * (4 * R - H);
        double V = Math.PI * H * H * (R - H / 3);

        // Вывод результатов
        Console.WriteLine("\n--- Результаты ---");
        Console.WriteLine($"Боковая поверхность     Sбок  = {S_bok:F4}");
        Console.WriteLine($"Полная поверхность      Sполн = {S_poln:F4}");
        Console.WriteLine($"Объём сегмента          V     = {V:F4}");
        
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}