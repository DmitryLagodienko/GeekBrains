using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где
//m-масса тела в килограммах, h - рост в метрах.

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 70;
            double h = 1.75;
            double i = m / (h * h);
            Console.WriteLine($"При росте {h} м и массе {m} кг, индекс массы человека равен {i:.###}");
            Console.ReadKey();
        }
    }
}
