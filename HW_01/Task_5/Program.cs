using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5.С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isNum;
            while (true)
            {
                Console.Write("Введите номер месяца: ");
                isNum = int.TryParse(Console.ReadLine(), out num);
                if (isNum)
                {
                    if (num == 12 || num == 1 || num == 2)
                        Console.WriteLine("Это зима");
                    else if (num >= 3 && num <= 5)
                        Console.WriteLine("Это весна");
                    else if (num >= 6 && num <= 8)
                        Console.WriteLine("Это лето");
                    else if (num >= 9 && num <= 11)
                        Console.WriteLine("Это осень");
                    else
                        Console.WriteLine("Такого месяца нет");
                }
                else
                    Console.WriteLine("Нужно ввести целое число от 1 до 12");
            }
        }
    }
}
