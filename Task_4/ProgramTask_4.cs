using System;

namespace Task_4
{
    /*
    4.  Написать программу обмена значениями двух переменных:
        а) с использованием третьей переменной;
        б) *без использования третьей переменной

    Лагодиенко Дмитрий
    */
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            // 1-й способ
            Console.WriteLine($"До: a = {a}, b = {b}");
            int c = b;
            b = a;
            a = c;
            Console.WriteLine($"После: a = {a}, b = {b}");

            // 2-й способ
            Console.WriteLine($"\nДо: a = {a}, b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"После: a = {a}, b = {b}");

            Console.ReadKey();
        }
    }
}