using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Task_2
{
    class Message
    {
        //  Метод выводит только те слова сообщения msg, которые содержат не более n букв.
        public static void GetWords(string msg, int n)
        {
            string pattern = @"\b\w{1," + n + @"}\b";
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(msg);
            if (matches.Count > 0)
            {
                Console.WriteLine("Слова, которые содержат не более " + n + " букв:");
                foreach (Match match in matches)
                    Console.Write(match.Value + " ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }

        //  Метод удаляет из сообщения msg все слова, которые заканчиваются на заданный символ c.
        public static void RemoveWords(string msg, char c)
        {
            string pattern = @"(\b\w{0,}" + c + @"\b) | (\b\w{0,}" + c + @"\b)|(\b\w{0,}" + c + @"\b)";
            Regex reg = new Regex(pattern);
            string target = "";
            msg = reg.Replace(msg, target);
            Console.WriteLine("Текст без слов с последней буквой \'" + c + "\'");
            Console.WriteLine(msg);
        }

        // Метод находит самое длинное слово сообщения.
        public static string GetLongWord(string msg)
        {
            string pattern = @"\b\w{1,}\b";
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(msg);
            string longWord = "";
            foreach (Match match in matches)
                if (match.Length > longWord.Length)
                    longWord = Convert.ToString(match);
            return longWord;
        }

        //  Метод с помощью StringBuilder формирует строку lm из самых длинных слов сообщения msg.
        public static void GetLongMessage(string msg)
        {
            StringBuilder sb = new StringBuilder(msg);
            for (int i = 0; i < sb.Length;)
                if (char.IsPunctuation(sb[i]))
                    sb.Remove(i, 1);
                else
                    ++i;
                    
            string str = sb.ToString();
            string[] s = str.Split(' ', '\r');
            StringBuilder lm = new StringBuilder("");
            string longWord = GetLongWord(msg);
            for (int i = 0; i < s.Length; i++)
                if (s[i].Length == longWord.Length)
                    lm.Append(s[i] + " ");
            Console.WriteLine("Самые длинные слова:");
            Console.WriteLine(lm);
        }
    }
}
