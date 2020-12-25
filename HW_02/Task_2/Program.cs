using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Реализовать функцию возведения числа a в степень b:
//a.Без рекурсии.
//b.Рекурсивно.
//c. *Рекурсивно, используя свойство чётности степени.

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 17;
            uint b = 22;
            double c;

            // возведение a в степень b без рекурсии
            c = 1;
            for (int i = 0; i < b; i++)
                c *= a;
            Console.WriteLine(c);

            //С использованием рекурсии
            c = 1;
            c = Degree(a, b);
            Console.WriteLine(c);

            // с использованием "доработанной" рекурсии
            c = 1;
            c = ParityDegree(a, b);
            Console.WriteLine(c);
            Console.ReadKey();
        }

        static double Degree(double a, uint b)
        {
            if (b > 0)
                return a * Degree(a, b - 1);
            else
                return 1;
        }

        static double ParityDegree(double a, uint b)
        {
            if (b == 0)
                return 1;
            else if (b % 2 == 0)
                return ParityDegree(a, b / 2) * ParityDegree(a, b / 2);
            else
                return a * ParityDegree(a, b - 1);
        }
    }
}
