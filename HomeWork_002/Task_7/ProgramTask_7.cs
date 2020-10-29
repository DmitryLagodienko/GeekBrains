using System;

namespace Task_7
{
    /*
    7.  a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        б) *Разработать рекурсивный метод, который считает сумму чисел от a до b
    
    Лагодиенко Дмитрий
    */
    class ProgramTask_7
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            ShowNumbers(a, b);
            int sum = GetSum(a, b);
            Console.WriteLine($"\nСумма чисел: {sum}");
            Console.ReadKey();
        }

        static void ShowNumbers(int a, int b)
        {
            if (a <= b)
            {
                Console.Write(a + " ");
                ShowNumbers(a + 1, b);
            }
        }

        static int GetSum(int a, int b)
        {
            if (a < b)
                return a + GetSum(a + 1, b);
            else
                return b;
        }
    }
}