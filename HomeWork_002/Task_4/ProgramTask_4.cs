using System;

namespace Task_4
{
    /*
    4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
    программа пропускает его дальше или не пропускает.
    С помощью цикла do while ограничить ввод пароля тремя попытками.
    
    Лагодиенко Дмитрий
    */
    class ProgramTask_4
    {
        static void Main(string[] args)
        {
            int count = 1;
            do
            {
                Console.WriteLine($"Попытка № {count}");
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Password: ");
                string psw = Console.ReadLine();
                if (Compare(login, psw))
                {
                    Console.Write("\nДоступ открыт");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверные login/password\n");
                    if (count == 3)
                        Console.WriteLine("Попыток больше нет");
                }
                count++;
            } while (count <= 3);
            Console.ReadKey();
        }

        static bool Compare(string login, string psw)
        {
            return login == "root" && psw == "GeekBrains";
        }
    }
}