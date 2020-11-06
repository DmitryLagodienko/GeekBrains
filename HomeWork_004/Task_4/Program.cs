using System;
using System.IO;

namespace Task_4
{
    //  Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    //  Создайте структуру Account, содержащую Login и Password. 
    //
    //  Вторую часть задания не доделал, т.к. не понял, какие логин и пароль должны быть в структуре - пользовательские или оригинальные
    //  Лагодиенко Дмитирий
    struct Account
    {
        string Login;
        string Password;
    }

    class Program
    {
        static bool Compare(string login, string psw)
        {
            return login == "root" && psw == "GeekBrains";
        }

        static void Main(string[] args)
        {
            int count = 1;
            string fileName = "lp.txt";
            string[] lp = new string[2];
            do
            {
                Console.WriteLine($"Попытка № {count}");
                try
                {
                    StreamReader sr = new StreamReader(fileName);
                    for (int i = 0; !sr.EndOfStream; i++)
                    {
                        lp[i] = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch
                {
                    Console.WriteLine($"Не удалось открыть файл {fileName}");
                }
                
                if (Compare(lp[0], lp[1]))
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
    }
}
