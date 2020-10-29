using System;

namespace Task_2
{
    /*
    2. Написать метод подсчета количества цифр числа.
    
    Лагодиенко Дмитрий
    */
    class ProgramTask_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("К О Л И Ч Е С Т В О   Ц И Ф Р   В   Ч И С Л Е\n");
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            while (number > 0)
            {
                number = number / 10;
                count++;
            }

            Console.Write($"Цифр в числе: {count}");
            Console.ReadKey();
        }
    }
}