using System;
using System.IO;

namespace Task_2
{
    //  Реализуйте задачу 1 в виде статического класса StaticClass;
    //  а) Класс должен содержать статический метод, который принимает на вход массив и решает
    //  задачу 1;
    //  б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен
    //  возвращать массив целых чисел;
    //  в)** Добавьте обработку ситуации отсутствия файла на диске.
    //
    //  Лагодиенко Дмитрий
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 20;
            int[] arr1 = new int[size];

            for (int i = 0; i < size; i++)
                arr1[i] = rand.Next(-10000, 10001);
            int couples = MyArray.GetCouples(arr1);

            foreach (int element in arr1)
                Console.WriteLine(element);
            Console.WriteLine($"Количество пар: {couples}");
            Console.WriteLine();

            // обработка исключения "отсутствие файла"
            string fileName = "data.txt";
            try
            {
                StreamReader sr = new StreamReader(fileName);
                int[] arr2 = MyArray.GetArrayFromFile(sr);
                sr.Close();
                Console.WriteLine($"Массив из файла \"{fileName}\":");
                foreach (int element in arr2)
                    Console.Write(element + " ");
            }
            catch
            {
                Console.WriteLine($"Не удалось открыть файл {fileName}");
            }
            Console.ReadKey();
        }
    }

    static class MyArray
    {
        public static int GetCouples(int[] a)
        {
            int couples = 0;

            for (int i = 0, j = a.Length - 1; i < a.Length - 1 && j > 0; i++, j--)
            {
                if (a[i] % 3 == 0 && a[i + 1] % 3 != 0)
                    couples++;
                if (a[j] % 3 == 0 && a[j - 1] % 3 != 0)
                    couples++;
            }
            return couples;
        }

        public static int[] GetArrayFromFile(StreamReader sr)
        {
            string line = sr.ReadLine();
            int size = Convert.ToInt32(line);
            int[] a = new int[size];

            for (int i = 0; i < size; i++)
            {
                line = sr.ReadLine();
                a[i] = Convert.ToInt32(line);
            }
            return a;
        }
    }
}
