using System;
using System.IO;

namespace Task_2
{
    //  Разработать класс Message, содержащий следующие статические методы для обработки текста:
    //  а) Вывести только те слова сообщения, которые содержат не более n букв.
    //  б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //  в) Найти самое длинное слово сообщения.
    //  г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //  Продемонстрируйте работу программы на текстовом файле с вашей программой.
    //
    //  Лагодиенко Дмитрий

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("data.txt");
            string msg = sr.ReadToEnd();
            sr.Close();
            Message.GetWords(msg, 3);
            Console.WriteLine();
            Message.RemoveWords(msg, 'ь');
            Console.WriteLine();
            Console.WriteLine("Самое длинное слово: " + Message.GetLongWord(msg));
            Console.WriteLine();
            Message.GetLongMessage(msg);
            Console.ReadKey();
        }
    }
}
