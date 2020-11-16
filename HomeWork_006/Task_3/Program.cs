using System;
using System.Collections.Generic;
using System.IO;

namespace Task_3
{
    //  Переделать программу «Пример использования коллекций» для решения следующих задач:
    //  а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //  б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
    //  в) отсортировать список по возрасту студента;
    //  г) * отсортировать список по курсу и возрасту студента;
    //
    //  Лагодиенко Дмитрий

    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        public Student(string firstName, string lastName, string university, string faculty, string department,  int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
    }

    class Program
    {
        // Сориторовка по возрасту студента
        static int MyDelegatAge(Student st1, Student st2)
        {
            return st1.age.CompareTo(st2.age);
        }
        // Сортировка по курсу и возрасту студента
        static int MyDelegatCourseAge(Student st1, Student st2)
        {
            int priority = st1.course.CompareTo(st2.course);
            return priority == 0 ? st1.age.CompareTo(st2.age) : st1.course.CompareTo(st2.course);
        }

        static void Main(string[] args)
        {
            int students56 = 0;
            int[,] studentAgeCourse = new int[6,3];
            List<Student> list = new List<Student>();

            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Подсчитываем количество студентов 5 и 6 курсов
                    int course = int.Parse(s[6]);
                    if (course == 5 || course == 6)
                        students56++;
                    // Подсчитываем сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив)
                    int age = int.Parse(s[5]);
                    if (age == 18)
                        studentAgeCourse[course, 0]++;
                    else if (age == 19)
                        studentAgeCourse[course, 1]++;
                    else if (age == 20)
                        studentAgeCourse[course, 2]++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            Console.WriteLine("Сортировка по возрасту:");
            list.Sort(new Comparison<Student>(MyDelegatAge));
            foreach (Student st in list)
                Console.WriteLine($"{st.firstName} {st.lastName}. Возраст - {st.age}");
            Console.WriteLine();

            Console.WriteLine("Сортировка по курсу и возрасту:");
            list.Sort(new Comparison<Student>(MyDelegatCourseAge));
            foreach (Student st in list)
                Console.WriteLine($"{st.firstName} {st.lastName}. {st.course} курс , возраст - {st.age}");
            Console.WriteLine();

            Console.WriteLine($"Студентов 5 и 6 курсов: {students56}");
            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Молодые студенты {i+1} курса:");
                Console.WriteLine($"18 лет - {studentAgeCourse[i, 0]}");
                Console.WriteLine($"19 лет - {studentAgeCourse[i, 1]}");
                Console.WriteLine($"20 лет - {studentAgeCourse[i, 2]}");
                Console.WriteLine($"Всего - {studentAgeCourse[i, 0] + studentAgeCourse[i, 1] + studentAgeCourse[i, 2]}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
