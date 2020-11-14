using System;
using System.Text;

namespace Task_1a
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
            string set = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder login;
            bool OK;
            do
            {
                OK = true;
                Console.Write("Введите логин: ");
                login = new StringBuilder(Console.ReadLine());
                if (login.Length < 2 || login.Length > 10)
                {
                    Console.WriteLine("Логин должен содержать от 2 до 10 символов");
                    OK = false;
                }
                if (login.Length != 0 || login[0] < 48 || login[0] < 58)
                {
                    Console.WriteLine("Логин не может начинаться с цифры");
                    OK = false;
                }
                for (int i = 0; i < login.Length; i++)
                {
                    if (set.IndexOf(login[i]) == -1)
                    {
                        Console.WriteLine("Логин должен содержать только цифры или буквы латинского алфавита");
                        OK = false;
                        break;
                    }
                }
            } while (!OK);
            Console.WriteLine("ОК!");
            Console.ReadKey();
        }
    }
}
