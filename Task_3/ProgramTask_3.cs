using System;

namespace Task_3
{
    /*
    3.  а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
        y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
        используя спецификатор формата .2f (с двумя знаками после запятой);
        б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
        метода

    Лагодиенко Дмитрий
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Р А С С Т О Я Н И Е   М Е Ж Д У   Т О Ч К А М И\n");
            Console.Write("X1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("X2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками: {r:f2}");
            // с помощью метода GetDistance()
            r = GetDistance(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками: {r:f2}");
            Console.ReadKey();
        }

        static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}