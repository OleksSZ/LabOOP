using System;

namespace OOPExample
{
    class Movement
    {
        public double Speed { get; set; }
        public double Time { get; set; }

        public Movement(double speed, double time)
        {
            Speed = speed;
            Time = time;
        }

        public double CalculateDistance()
        {
            return Speed * Time;
        }

        public void PrintTable()
        {
            double distance = CalculateDistance();
            Console.WriteLine("\nРезультати:");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10}", "Скорость", "Час", "Дистанция");
            Console.WriteLine(new string('-', 35));
            Console.WriteLine("{0,-10:F1} | {1,-10:F1} | {2,-10:F1}", Speed, Time, distance);
        }
    }

    class Converter
    {
        public static void ConvertIntToDouble()
        {
            Console.Write("Введіть ціле число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                double converted = number; // неявное преобразование
                string output = String.Format("Ціле: {0}, як double: {1:F1}", number, converted);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Некорректний ввід!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВиберіть дію:");
                Console.WriteLine("1 - Розрахувати дистанцію");
                Console.WriteLine("2 - Преобразовати ціле число в double");
                Console.WriteLine("0 - Вивід");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть швидкість: ");
                        if (!double.TryParse(Console.ReadLine(), out double speed))
                        {
                            Console.WriteLine("Некорректный ввод!");
                            break;
                        }

                        Console.Write("Введіть час: ");
                        if (!double.TryParse(Console.ReadLine(), out double time))
                        {
                            Console.WriteLine("Некорректний ввід!");
                            break;
                        }

                        Movement move = new Movement(speed, time);
                        move.PrintTable();
                        break;

                    case "2":
                        Converter.ConvertIntToDouble();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }
            }
        }
    }
}
