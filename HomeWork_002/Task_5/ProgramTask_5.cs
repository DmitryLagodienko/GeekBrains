using System;

namespace Task_5
{
    /*
    5.  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
        массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    
    Лагодиенко Дмитрий
    */
    class ProgramTask_5
    {
        static void Main(string[] args)
        {
            int minI = 18;
            int maxI = 25;

            Console.WriteLine("И Н Д Е К С   М А С С Ы   Т Е Л А\n");
            Console.Write("Вес человека (кг): ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Рост человека (м): ");
            float height = float.Parse(Console.ReadLine());
            float I = weight / (height * height);
            Console.WriteLine($"\nИндекс массы тела (ИМТ): {I:f2}");
            if (I > maxI)
            {
                float difference = weight - maxI * height * height;
                Console.Write($"Не помешало бы сбросить {difference:f2} кг");
            }
            else if (I < minI)
            {
                float difference = minI * height * height - weight;
                Console.Write($"Не помешало бы набрать {difference:f2} кг");
            }
            else
            {
                Console.WriteLine("Вес в норме");
            }
            Console.ReadKey();
        }
    }
}