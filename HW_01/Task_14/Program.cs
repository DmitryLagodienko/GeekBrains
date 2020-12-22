using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14. * Автоморфные числа.Натуральное число называется автоморфным, если оно равно последним
//цифрам своего квадрата. Например, 25 \ :sup: `2` = 625.Напишите программу, которая вводит
//натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            int count;
            for (long i = 2; i <= N; i++)
            {
                long j = i;
                count = 1;
                while (j > 0)
                {
                    j /= 10;
                    count *= 10;
                }
                if (i*i % count == i)
                    Console.WriteLine($"{i}  ");
            }
            Console.WriteLine("Список окончен");
            Console.ReadKey();
        }
    }
}
