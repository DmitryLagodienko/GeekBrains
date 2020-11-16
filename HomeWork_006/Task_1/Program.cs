using System;

namespace Task_1
{
    //  Изменить программу вывода функции так, чтобы можно было
    //  передавать функции типа double (double, double).
    //  Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
    //
    //  Лагодиенко Дмитрий

    public delegate double Fun(double x, double a);

    class Program
    {
        public static void Table(Fun F, double x, double a, double b)
        {
            Console.WriteLine("----- X ------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }
        
        public static double MyFuncSquare(double x, double a)
        {
            return a * x * x;
        }

        public static double MyFuncSin(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            double a = 5;
            Console.WriteLine($"Таблица функции MyFuncSquare ( Y = a* X^2 ), a = {a}");
            Table((MyFuncSquare), -2, 5, 2);
            a = 3;
            Console.WriteLine($"Таблица функции MyFuncSin ( Y = a* sin(X) ), a = {a}");
            Table(MyFuncSin, -2, 3, 2);
            Console.ReadKey();
        }
    }
}
