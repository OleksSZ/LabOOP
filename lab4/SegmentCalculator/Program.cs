using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Розрахунок шарового сегмента ===\n");

        // Ввод данных
        Console.Write("Введіть радіус сферы R: ");
        double R = double.Parse(Console.ReadLine());

        Console.Write("Введіть висоту сегмента H: ");
        double H = double.Parse(Console.ReadLine());

        // Вычисления по формулам
        double S_bok = 2 * Math.PI * R * H;
        double S_poln = Math.PI * H * (4 * R - H);
        double V = Math.PI * H * H * (R - H / 3);

        // Вывод результатов
        Console.WriteLine("\n--- Результати ---");
        Console.WriteLine($"Бокова поверхня     Sбок  = {S_bok:F4}");
        Console.WriteLine($"Полна поверхня      Sполн = {S_poln:F4}");
        Console.WriteLine($"Об'єм сегмента          V     = {V:F4}");
        
        Console.WriteLine("\nНажміть любу клавішу для виходу...");
        Console.ReadKey();
    }
}