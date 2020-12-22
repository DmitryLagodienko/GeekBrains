using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12.Написать функцию нахождения максимального из трех чисел.

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            int max = Max(a, b, c);
            Console.WriteLine($"Наибольшее число: {max}");
            Console.ReadKey();
        }

        static int Max(int x, int y, int z)
        {
            if (x > y && x > z)
                return x;
            else if (y > x && y > z)
                return y;
            else
                return z;
        }
    }
}
