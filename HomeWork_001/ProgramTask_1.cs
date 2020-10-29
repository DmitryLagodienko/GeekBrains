using System;

namespace Task_1
{
    /*
    1.  Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
        рост, вес). В результате вся информация выводится в одну строчку:
        а) используя склеивание;
        б) используя форматированный вывод;
        в) используя вывод со знаком $.
    
    Лагодиенко Дмитрий
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("А Н К Е Т А\n");
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Возраст: ");
            string age = Console.ReadLine();
            Console.Write("Рост: ");
            string height = Console.ReadLine();
            Console.Write("Вес: ");
            string weight = Console.ReadLine();
            // склеивание
            Console.WriteLine(name + " " + surname + ", возраст - " + age + ", рост - " + height + ", вес - " + weight);
            // форматированный вывод
            Console.WriteLine("{0} {1}, возраст - {2}, рост - {3}, вес - {4}", name, surname, age, height, weight);
            // интерполяция
            Console.WriteLine($"{name} {surname}, возраст - {age}, рост - {height}, вес - {weight}");
            Console.ReadKey();
        }
    }
}