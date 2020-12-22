using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.Ввести возраст человека(от 1 до 150 лет) и вывести его вместе с последующим словом «год»,
//«года» или «лет».

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool isNum;
            while (true)
            {
                Console.Write("Введите возраст человека (от 1 до 150): ");
                isNum = int.TryParse(Console.ReadLine(), out age);
                if (isNum && age >=1 && age <= 150)
                {
                    if (age >= 5 && age <= 14)
                        Console.WriteLine($"{age} лет");
                    else if (age % 10 == 1 && age != 11)
                        Console.WriteLine($"{age} год");
                    else if (age % 10 == 2 || age % 10 == 3 || age % 10 == 4)
                        Console.WriteLine($"{age} года");
                    else
                        Console.WriteLine($"{age} лет");
                }
                else
                    Console.WriteLine("Введите корректные данные");
            }
        }
    }//
}
