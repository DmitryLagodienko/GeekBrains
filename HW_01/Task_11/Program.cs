using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//11.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое всех
//положительных четных чисел, оканчивающихся на 8.

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -1;
            int sum = 0;
            int count = 0;
            do
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num > 0 && (num % 10) == 8)
                    {
                        sum += num;
                        count++;
                    }
                }
                else
                {
                    num = -1;
                }
                    
            } while (num != 0);
            if (count != 0)
                Console.WriteLine($"Среднее арифметическое чисел равно: {sum / count}");
            else
                Console.WriteLine("Нет чисел, удовлетворяющих условиям задачи");
            Console.ReadKey();
        }
    }
}
