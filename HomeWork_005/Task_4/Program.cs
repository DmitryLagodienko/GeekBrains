using System;
using System.IO;

namespace Task_4
{
    //  Задача ЕГЭ.
    //  *На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
    //  школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
    //  превосходит 100, каждая из следующих N строк имеет следующий формат:
    //  <Фамилия> <Имя> <оценки>,
    //  где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
    //  более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
    //  пятибалльной системе. <Фамилия> и<Имя>, а также <Имя> и<оценки> разделены одним пробелом.
    //  Пример входной строки:
    //  Иванов Петр 4 5 3
    //  Требуется написать как можно более эффективную программу, которая будет выводить на экран
    //  фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
    //  набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
    //  Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в
    //  начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения
    //  задач используйте неизменяемые строки (string)
    //
    //  Лагодиенко Дмитрий
    struct Student
    {
        public string FIO;
        public int N;
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("data.txt");
            int N = int.Parse(sr.ReadLine());
            Student[] students = new Student[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                students[i].FIO = s[0] + " " + s[1];
                students[i].N = int.Parse(s[2]) + int.Parse(s[3]) + int.Parse(s[4]);
            }
            sr.Close();

            int max = students[0].N;
            int min = students[0].N;
            foreach (Student st in students)
                if (st.N < min)
                    min = st.N;
                else if (st.N > max)
                    max = st.N;

            Student[] losers;
            GetLosers(students, out losers, min, max);

            foreach (Student loser in losers)
                Console.WriteLine(loser.FIO);

            Console.ReadKey();
        }

        private static void GetLosers(Student[] students, out Student[] losers, int min, int max)
        {
            int count = 0;
            while (count < 3)
            {
                foreach (Student st in students)
                    if (st.N == min)
                        count++;
                if (count < 3)
                {
                    int tempMax = max;
                    foreach (Student st in students)
                        if (st.N > min && st.N < tempMax)
                            tempMax = st.N;
                    min = tempMax;
                }
            }
            losers = new Student[count];
            int i = 0;
            foreach (Student st in students)
                if (st.N <= min)
                {
                    losers[i] = st;
                    i++;
                }
        }
    }
}