using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Реализовать функцию перевода чисел из десятичной системы в двоичную, используя
//рекурсию.

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 16;
            string answer = "";

            Translate(number, ref answer);

            char[] sReverse = answer.ToCharArray();
            Array.Reverse(sReverse);
            answer = new string(sReverse);

            Console.WriteLine(answer);
            Console.ReadKey();
        }

        static void Translate(int n, ref string answer)
        {
            if (n > 1)
            {
                answer += Convert.ToString(n % 2);
                Translate(n / 2, ref answer);
            }
            else
                answer += Convert.ToString(1);
        }
    }
}
