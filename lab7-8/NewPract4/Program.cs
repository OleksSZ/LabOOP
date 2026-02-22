using System;

class Program
{
    static void Main()
    {
        double a = 0.5;
        double b = 3.1;
        double x = 1.4;

        double sin2x= Math.Sin(2 * x);
        double exp_neg_x= Math.Exp(-x);
        double inside= a * x * x * sin2x + exp_neg_x * (x + b);
        double alpha= Math.Sqrt(Math.Abs(inside));

        double sqrt_ab= Math.Sqrt(a * a + b * b);
        double x3= x * x * x;
        double cos_x3_sq= Math.Pow(Math.Cos(x3), 2);
        double phi= (1.0 / (cos_x3_sq * sqrt_ab)) - (x / sqrt_ab);


        Console.WriteLine("=== Демонстрація checked / unchecked ===\n");

        int max = int.MaxValue;   // 2_147_483_647

        try
        {
            checked
            {
                int resultChecked = max + 10;// тут буде OverflowException
                Console.WriteLine("  checked:  " + resultChecked);  // ніколи не виконається
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("  checked:  переповнення виявлено (OverflowException)");
        }

        unchecked
        {
            int resultUnchecked = max + 10;
            Console.WriteLine("  unchecked: " + resultUnchecked);
        }

        Console.WriteLine("\n=== Основні результати задачі ===");
        Console.WriteLine($"a = {a}, b = {b}, x = {x}\n");
        Console.WriteLine($"α  ≈ {alpha:F6}");
        Console.WriteLine($"φ  ≈ {phi:F6}");

        Console.WriteLine("\nГотово. Натисніть будь-яку клавішу...");
        Console.ReadKey();
    }
}