using System;

namespace Task_1
{
    //  Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
    //  значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
    //  программу, позволяющую найти и вывести количество пар элементов массива, в которых только
    //  одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
    //  элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
    //
    //  Лагодиенко Дмитрий
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 20;
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(-10000, 10001);

            foreach(int number in arr)
                Console.Write($"{number} ");

            int couples = 0;

            for (int i = 0, j = size - 1; i < size - 1 && j > 0; i++, j--)
            {
                if (arr[i] % 3 == 0 && arr[i + 1] % 3 != 0)
                    couples++;
                if (arr[j] % 3 == 0 && arr[j - 1] % 3 != 0)
                    couples++;
            }
            Console.WriteLine("\n" + couples);
            Console.ReadKey();
        }
    }
}
