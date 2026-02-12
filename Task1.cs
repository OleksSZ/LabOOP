using System;

namespace OOPExample
{
    // Класс для движения
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ввести швидкість та час руху
            Console.Write("Введите скорость: ");
            double speed = double.Parse(Console.ReadLine());

            Console.Write("Введите время: ");
            double time = double.Parse(Console.ReadLine());

            // Создаём объект движения
            Movement move = new Movement(speed, time);

            // 2. Обчислити відстань
            double distance = move.CalculateDistance();

            // 3. Вывести таблицу с форматированием F1
            Console.WriteLine("\nРезультаты:");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10}", "Скорость", "Время", "Дистанция");
            Console.WriteLine(new string('-', 35));
            Console.WriteLine("{0,-10:F1} | {1,-10:F1} | {2,-10:F1}", move.Speed, move.Time, distance);

            // 4. Ввести целое число и неявно преобразовать в double
            Console.Write("\nВведите целое число: ");
            int number = int.Parse(Console.ReadLine());
            double converted = number; // неявное преобразование

            // 5. Вывести через String.Format()
            string output = String.Format("Целое: {0}, как double: {1:F1}", number, converted);
            Console.WriteLine(output);
        }
    }
}
