using System;
using System.Text.RegularExpressions;

namespace Task_1b
{
    //  Создать программу, которая будет проверять корректность ввода логина. Корректным
    //  логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
    //  или цифры, при этом цифра не может быть первой:
    //  а) без использования регулярных выражений;
    //  б) ** с использованием регулярных выражений.
    //
    //Лагодиенко Дмитрий
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex("^[A-Za-z][A-Za-z0-9]{1,9}$");
            string login;
            bool OK;
            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                if (reg.IsMatch(login))
                {
                    Console.WriteLine("ОК!");
                    OK = true;
                }
                else
                {
                    Console.WriteLine("Логин введён неверно");
                    OK = false;
                }
            } while (!OK);
            Console.ReadKey();
        }
    }
}
