using System;

namespace Task_2
{
    /*
    2.  Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
        I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
    
    Лагодиенко Дмитрий
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("И Н Д Е К С   М А С С Ы   Т Е Л А\n");
            Console.Write("Вес человека (кг): ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Рост человека (м): ");
            float height = float.Parse(Console.ReadLine());
            float I = weight / (height * height);
            Console.Write($"\nИндекс массы тела (ИМТ): {I:f2}");
            Console.ReadKey();
        }
    }
}