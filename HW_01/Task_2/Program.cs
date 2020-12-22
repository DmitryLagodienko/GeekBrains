using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Найти максимальное из четырех чисел. Массивы не использовать.

// Сначала решил это задание с помощью функции, но потом наткнулся на похожее в № 12,
// поэтому переделал - использовал ветвление, заодно как бы раскрыв одну из тем урока

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 7;
            int d = 4;

            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                        Console.WriteLine($"{a} самое большое число");
                    else
                        Console.WriteLine($"{d} самое большое число");
                }
                else
                {
                    if (c > d)
                        Console.WriteLine($"{c} самое большое число");
                    else
                        Console.WriteLine($"{d} самое большое число");
                }
            }
            else
            {
                if (b > c)
                {
                    if (b > d)
                        Console.WriteLine($"{b} самое большое число");
                    else
                        Console.WriteLine($"{d} самое большое число");
                }
                else
                {
                    if (c > d)
                        Console.WriteLine($"{c} самое большое число");
                    else
                        Console.WriteLine($"{d} самое большое число");
                }
            }
            Console.ReadKey();
        }
    }
}
