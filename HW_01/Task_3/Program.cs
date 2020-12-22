using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Написать программу обмена значениями двух целочисленных переменных:
//  a. с использованием третьей переменной;
//  b. * без использования третьей переменной.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            int c = a;
            a = b;
            b = c;

            // или

            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
