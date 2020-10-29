using System;

namespace Task_1
{
    /*
    1. Написать метод, возвращающий минимальное из трех чисел.
    
    Лагодиенко Дмитрий
    */
    class ProgramTask_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Н А И М Е Н Ь Ш Е Е   Ч И С Л О\n");
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите число c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (a < b && a < c)
                Console.Write($"Наименьшее число {a}");
            else if (b < c)
                Console.Write($"Наименьшее число {b}");
            else
                Console.Write($"Наименьшее число {c}");

            Console.ReadKey();
        }
    }
}