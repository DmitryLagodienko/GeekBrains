using System;

namespace Task_3
{
    /*
    3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    
    Лагодиенко Дмитрий
    */
    class ProgramTask_3
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number;

            Console.WriteLine("СУММА ВСЕХ НЕЧЕТНЫХ ПОЛОЖИТЕЛЬНЫХ ЧИСЕЛ\n");
            do
            {
                Console.Write("Введите число: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 1)
                    sum += number;
            } while (number != 0);
            Console.Write($"Сумма: {sum}");
            Console.ReadKey();
        }
    }
}