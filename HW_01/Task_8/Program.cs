using System;

//8.Ввести a и b и вывести квадраты и кубы чисел от a до b.

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            bool isNum = false;
            while (!isNum)
            {
                Console.Write("Введите число a: ");
                isNum = int.TryParse(Console.ReadLine(), out a);
            }
            isNum = false;
            while (!isNum || a >= b)
            {
                Console.Write("Введите число b (должно быть больше числа a): ");
                isNum = int.TryParse(Console.ReadLine(), out b);
            }
            GetSQR(a, b);
            GetCB(a, b);

            Console.ReadKey();
        }

        static void GetSQR(int a, int b)
        {
            Console.WriteLine("Квадраты:");
            while (a <= b)
            {
                Console.Write($"{a * a}  ");
                a++;
            }
            Console.WriteLine();
        }

        static void GetCB(int a, int b)
        {
            Console.WriteLine("Кубы:");
            while (a <= b)
            {
                Console.Write($"{a * a * a}  ");
                a++;
            }
            Console.WriteLine();
        }
    }
}
