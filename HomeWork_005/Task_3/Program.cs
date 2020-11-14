using System;

namespace Task_3
{
    //  * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
    //  а) с использованием методов C#;
    //  б) * разработав собственный алгоритм.
    //  Например:
    //  badc являются перестановкой abcd.
    //
    //  Лагодоиенко Дмитрий
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "4qwerty";
            string str2 = "ytre4qw";
            Compare(str1, str2);
            Console.ReadKey();
        }

        //  Не совсем понял какие методы C# нужно использовать для части а),
        //  поэтому делаю 2 в 1: разработал собственный алгоритм с использованием методов C#
        private static void Compare(string str1, string str2)
        {
            bool OK = true;
            if (str1.Length != str2.Length)
                Console.WriteLine("Строки не являются перестановкой друг друга");
            else
            {
                char[] arr1 = str1.ToCharArray();
                Array.Sort(arr1);
                char[] arr2 = str2.ToCharArray();
                Array.Sort(arr2);
                for (int i = 0; i < arr1.Length; i++)
                    if (arr1[i] != arr2[i])
                    {
                        OK = false;
                        break;
                    }
                if (!OK)
                    Console.WriteLine("Строки не являются перестановкой друг друга");
                else
                    Console.WriteLine("Строки являются перестановкой друг друга");
            }
        }
    }
}
