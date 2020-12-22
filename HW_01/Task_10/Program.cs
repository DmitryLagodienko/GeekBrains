using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10.Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления
//определить, имеются ли в записи числа N нечетные цифры. Если имеются, то вывести True, если нет
//— вывести False.

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 246808642;
            int m;
            bool Odd = false;
            while(N > 0)
            {
                m = N % 10;
                if ( m % 2 == 1)
                    Odd = true;
                N /= 10;
            }
            Console.WriteLine(Odd);
            Console.ReadKey();
        }
    }
}
