using System;

namespace Task_5
{
    /*
    5.  а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        б) *Сделать задание, только вывод организовать в центре экрана.
        в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int
        x,int y)

    Лагодиенко Дмитрий
    */
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Дмитрий Лагодиенко, Челябинск";
            Console.Write(message);

            Console.SetCursorPosition(Console.WindowWidth / 2 - message.Length / 2, Console.WindowHeight / 2);
            Console.Write(message);

            // сместил вниз на 2, чтобы не перекрывало предыдущий вывод
            Print(message, Console.WindowWidth / 2 - message.Length / 2, Console.WindowHeight / 2 + 2);
            Console.ReadKey();
        }

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(msg);
        }
    }
}