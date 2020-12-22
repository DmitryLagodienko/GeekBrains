using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9.Даны целые положительные числа N и K. Используя только операции сложения и вычитания, найти
//частное от деления нацело N на K, а также остаток от этого деления.

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 111, K = 22;
            int QTNT = 0; // частное
            int RMNS; // остаток

            int k = K;
            while (N > k)
            {
                k += K;
                QTNT++;
            }
            RMNS = N - (k - K);
            Console.WriteLine($"Частное: {QTNT}\nОстаток: {RMNS}");
            Console.ReadKey();
        }
    }
}
