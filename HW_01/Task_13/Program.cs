using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//13. * Написать функцию, генерирующую случайное число от 1 до 100.
//  с использованием стандартной функции rand()
//  без использования стандартной функции rand()

// делаю только 1 вариант
namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(1, 100));
            Console.ReadKey();
        }
    }
}
