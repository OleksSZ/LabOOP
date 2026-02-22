// using System;

// namespace PointInAreaVariants
// {
//     abstract class AreaShape
//     {
//         public abstract bool Contains(double x, double y);
//         public abstract string Description { get; }
//     }

//     // Малюнок 1 — чверть кола зліва зверху + прямокутник справа
//     class QuarterCircleLeftTop : AreaShape
//     {
//         private readonly double R, H, L;

//         public QuarterCircleLeftTop(double r, double h, double l)
//         {
//             R = r; H = h; L = l;
//         }

//         public override bool Contains(double x, double y)
//         {
//             if (x <= 0)
//             {
//                 return x * x + y * y <= R * R && y >= 0;
//             }
//             else
//             {
//                 return x <= L && y >= 0 && y <= H;
//             }
//         }

//         public override string Description => 
//             "Чверть кола зліва зверху (x≤0, y≥0) + прямокутник справа (0<x≤L, 0≤y≤H)";
//     }

//     // Малюнок 2 — півколо знизу + прямокутник зверху
//     class SemicircleBottom : AreaShape
//     {
//         private readonly double R, H;

//         public SemicircleBottom(double r, double h)
//         {
//             R = r; H = h;
//         }

//         public override bool Contains(double x, double y)
//         {
//             if (y <= 0)
//             {
//                 // нижнє півколо: x² + y² ≤ R² та y ≤ 0
//                 return x * x + y * y <= R * R && y <= 0;
//             }
//             else
//             {
//                 // прямокутник зверху: |x| ≤ R, 0 < y ≤ H
//                 return Math.Abs(x) <= R && y <= H;
//             }
//         }

//         public override string Description => 
//             "Півколо знизу (y≤0) + прямокутник зверху (|x|≤R, 0<y≤H)";
//     }

//     // Малюнок 3 — півколо праворуч + прямокутник знизу
//     class SemicircleRight : AreaShape
//     {
//         private readonly double R, H;

//         public SemicircleRight(double r, double h)
//         {
//             R = r; H = h;
//         }

//         public override bool Contains(double x, double y)
//         {
//             if (x >= 0)
//             {
//                 // праве півколо: x² + y² ≤ R² та x ≥ 0
//                 return x * x + y * y <= R * R && x >= 0;
//             }
//             else
//             {
//                 // прямокутник зліва знизу: x ≥ -R, -H ≤ y ≤ 0
//                 return x >= -R && y >= -H && y <= 0;
//             }
//         }

//         public override string Description => 
//             "Півколо праворуч (x≥0) + прямокутник зліва знизу (-R≤x<0, -H≤y≤0)";
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.OutputEncoding = System.Text.Encoding.UTF8;
//             Console.InputEncoding = System.Text.Encoding.UTF8;

//             Console.WriteLine("=== Вибір типу області ===\n");

//             Console.WriteLine("1 → Чверть кола зліва зверху + прямокутник справа");
//             Console.WriteLine("2 → Півколо знизу + прямокутник зверху");
//             Console.WriteLine("3 → Півколо праворуч + прямокутник зліва знизу");
//             Console.WriteLine();

//             int variant = ReadIntInRange("Виберіть варіант (1-3): ", 1, 3);

//             AreaShape shape = null;
//             double r, h, l = 0;

//             switch (variant)
//             {
//                 case 1:
//                     r = ReadPositive("Радіус R: ");
//                     h = ReadPositive("Висота прямокутника H: ");
//                     l = ReadPositive("Довжина прямокутника L: ");
//                     shape = new QuarterCircleLeftTop(r, h, l);
//                     break;

//                 case 2:
//                     r = ReadPositive("Радіус півкола R: ");
//                     h = ReadPositive("Висота прямокутника H: ");
//                     shape = new SemicircleBottom(r, h);
//                     break;

//                 case 3:
//                     r = ReadPositive("Радіус півкола R: ");
//                     h = ReadPositive("Висота прямокутника H: ");
//                     shape = new SemicircleRight(r, h);
//                     break;
//             }

//             Console.WriteLine($"\nОбрано: {shape.Description}\n");

//             double x = ReadDouble("x = ");
//             double y = ReadDouble("y = ");

//             bool inside = shape.Contains(x, y);

//             Console.WriteLine("\n" + new string('═', 45));
//             if (inside)
//             {
//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Console.WriteLine("ТАК, точка ПОТРАПЛЯЄ в область ✓");
//             }
//             else
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("НІ, точка НЕ потрапляє в область ✗");
//             }
//             Console.ResetColor();

//             Console.WriteLine("\nНатисніть Enter...");
//             Console.ReadLine();
//         }

//         static int ReadIntInRange(string prompt, int min, int max)
//         {
//             while (true)
//             {
//                 Console.Write(prompt);
//                 if (int.TryParse(Console.ReadLine(), out int val) && val >= min && val <= max)
//                     return val;
//                 Console.WriteLine($"Введіть число від {min} до {max}!");
//             }
//         }

//         static double ReadPositive(string prompt)
//         {
//             while (true)
//             {
//                 Console.Write(prompt);
//                 if (double.TryParse(Console.ReadLine(), out double val) && val > 0)
//                     return val;
//                 Console.WriteLine("Введіть позитивне число!");
//             }
//         }

//         static double ReadDouble(string prompt)
//         {
//             while (true)
//             {
//                 Console.Write(prompt);
//                 if (double.TryParse(Console.ReadLine(), out double val))
//                     return val;
//                 Console.WriteLine("Введіть коректне число!");
//             }
//         }
//     }
// }

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

        int варіант = ReadInt("Виберіть варіант (1-3): ", 1, 3);

        Console.WriteLine();

        double r = ReadPositive("R = ");
        double h = ReadPositive("H = ");
        double l = (варіант == 1) ? ReadPositive("L = ") : 0;

        Console.WriteLine("\nВведіть координати точки:");
        double x = ReadDouble("x = ");
        double y = ReadDouble("y = ");

        bool всередині = варіант switch
        {
            1 => IsInVariant1(x, y, r, h, l),
            2 => IsInVariant2(x, y, r, h),
            3 => IsInVariant3(x, y, r, h),
            _ => false
        };

        Console.WriteLine("\n" + new string('═', 40));
        if (всередині)
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
            return x * x + y * y <= r * r && y >= 0;
        
        return x <= l && y >= 0 && y <= h;
    }

    static bool IsInVariant2(double x, double y, double r, double h)
    {
        if (y <= 0)
            return x * x + y * y <= r * r;
        
        return Math.Abs(x) <= r && y <= h;
    }

    static bool IsInVariant3(double x, double y, double r, double h)
    {
        if (x >= 0)
            return x * x + y * y <= r * r;
        
        return x >= -r && y >= -h && y <= 0;
    }


    static int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int val) && val >= min && val <= max)
                return val;
            Console.WriteLine($"Потрібно число від {min} до {max}");
        }
    }

    static double ReadPositive(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double val) && val > 0)
                return val;
            Console.WriteLine("Потрібне позитивне число");
        }
    }

    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double val))
                return val;
            Console.WriteLine("Введіть число");
        }
    }
}