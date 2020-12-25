using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3. * *Исполнитель «Калькулятор» преобразует целое число, записанное на экране. У
//исполнителя две команды, каждой присвоен номер:
//  1.Прибавь 1.
//  2.Умножь на 2.
//  Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза. Сколько
//  существует программ, которые число 3 преобразуют в число 20:
//  а.С использованием массива.
//  b. *С использованием рекурсии.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // решение с использованием массива

            int[] numberOfDecisions = new int[21];

            // инициализация массива
            for (int i = 0; i < 21; i++)
                numberOfDecisions[i] = 0;

            numberOfDecisions[3] = 1;

            for (int i = 3; i < 20; i++)
            {
                numberOfDecisions[i + 1] = numberOfDecisions[i];
                if ((i + 1) % 2 == 0)
                    numberOfDecisions[i + 1] += numberOfDecisions[(i + 1) / 2];
            }

            for (int i = 0; i < 21; i++)
                Console.Write(numberOfDecisions[i] + " ");
            Console.ReadKey();

            // решение с использованием рекурсии
            int n = 0;
            NumberOfDecisions(3, 20, ref n);
            Console.WriteLine("\n" + n);
            Console.ReadKey();
        }

        static void NumberOfDecisions(int a, int b, ref int count)
        {
            if (b - 1 > a)
                NumberOfDecisions(a, b - 1, ref count);
            if (b % 2 == 0 && b / 2 > a)
                NumberOfDecisions(a, b / 2, ref count);
            if (b - 1 == a || ((b % 2 == 0 && b / 2 == a)))
                count++;
        }
    }
}
