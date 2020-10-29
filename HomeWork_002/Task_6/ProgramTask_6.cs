using System;

namespace Task_6
{
    /*
    6.  *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
        000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать
        подсчёт времени выполнения программы, используя структуру DateTime.
    
    Лагодиенко Дмитрий
    */
    class ProgramTask_6
    {
        static void Main(string[] args)
        {
            int max = 1000000000; // почти 18 минут О_О
            int goodNumbCount = 0;

            DateTime start = DateTime.Now;
            for (int i = 1; i <= max; i++)
            {
                int sum = GetSum(i);
                if (i % sum == 0)
                {
                    Console.Write(i + " ");
                    goodNumbCount++;
                }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine($"\nВсего \"хороших\" чисел: {goodNumbCount}");
            Console.WriteLine($"Время выоплнения программы: {finish - start}");
            Console.ReadKey();
        }

        static int GetSum(int number)
        {
            if (number == 0)
                return 0;
            else
                return GetSum(number / 10) + number % 10;
        }
    }
}