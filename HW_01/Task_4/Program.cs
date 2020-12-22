using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.Написать программу нахождения корней заданного квадратного уравнения.

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // найдем корни квадратного уравнения вида 5x2 - 33x + 4 = 0
            double a = 5;
            double b = -33;
            double c = 4;

            double d = Discriminant(a, b, c);
            double x1, x2;
            if (d > 0)
            {
                Roots(a, b, d, out x1, out x2);
                Console.WriteLine($"X1 = {x1:f2}; X2 = {x2:f2}");
            }
            else if (d == 0)
            {
                Root(a, b, out x1);
                Console.WriteLine($"X1 = X2 = {x1:f2}");
            }
            else
                Console.WriteLine("Дискриминат D < 0, корней уравнения на множестве действительных чисел нет");

            Console.ReadKey();
        }

        static double Discriminant(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }

        static void Roots(double a, double b, double d, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
        }

        static void Root(double a, double b, out double x)
        {
            x = -b / (2 * a);
        }
    }
}
