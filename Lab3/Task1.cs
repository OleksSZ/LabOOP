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
            Console.WriteLine("\nРезультаты:");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10}", "Скорость", "Время", "Дистанция");
            Console.WriteLine(new string('-', 35));
            Console.WriteLine("{0,-10:F1} | {1,-10:F1} | {2,-10:F1}", Speed, Time, distance);
        }
    }

    class Converter
    {
        public static void ConvertIntToDouble()
        {
            Console.Write("Введите целое число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                double converted = number; // неявное преобразование
                string output = String.Format("Целое: {0}, как double: {1:F1}", number, converted);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Рассчитать расстояние");
                Console.WriteLine("2 - Преобразовать целое в double");
                Console.WriteLine("0 - Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите скорость: ");
                        if (!double.TryParse(Console.ReadLine(), out double speed))
                        {
                            Console.WriteLine("Некорректный ввод!");
                            break;
                        }

                        Console.Write("Введите время: ");
                        if (!double.TryParse(Console.ReadLine(), out double time))
                        {
                            Console.WriteLine("Некорректный ввод!");
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
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
    }
}
