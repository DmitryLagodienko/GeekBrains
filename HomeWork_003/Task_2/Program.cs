using System;

namespace Task_2
{
    /*
     2. а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    Требуется подсчитать сумму всех нечётных положительных чисел.
    Сами числа и сумму вывести на экран, используя tryParse

    Лагодиенко Дмитрий
    */
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string numbers = "";
            int sum = 0;
            int num;

            do
            {
                Console.Write("Введите число (чтобы закончить, введите 0): ");
                userInput = Console.ReadLine();
                bool isNum = int.TryParse(userInput, out num);
                if (isNum && num > 0 && num % 2 == 1)
                {
                    numbers += userInput + " ";
                    sum += num;
                }
            } while (userInput != "0");

            Console.WriteLine($"Нечетные положительные числа: {numbers}");
            Console.WriteLine($"Их сумма: {sum}");

            Console.ReadKey();
        }
    }
}
