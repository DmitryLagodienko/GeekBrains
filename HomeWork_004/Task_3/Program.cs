using System;
using System.Collections.Generic;
using MyArrayLibrary;

namespace Task_3
{
    //  а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий
    //  массив определенного размера и заполняющий массив числами от начального значения с
    //  заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод
    //  Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый
    //  массив остается без изменений), метод Multi, умножающий каждый элемент массива на
    //  определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
    //
    //  б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу
    //  библиотеки
    //
    //  е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
    //
    //  Лагодиенко Дмитрий
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(5, 2, 3);

            Console.WriteLine($"Мой массив: {arr.ToString()}");
            Console.WriteLine($"Сумма элементов массива: {arr.Sum}");
            int[] arr2 = arr.Inverse();
            Console.Write("Массив-инверсия: ");
            foreach (int element in arr2)
                Console.Write(element + " ");
            Console.WriteLine();
            int multiplier = 2;
            arr.Multi(multiplier);
            Console.WriteLine($"Массив, умноженный на {multiplier}: {arr.ToString()}");
            Console.WriteLine($"Количество максимальных элементов в массиве: {arr.MaxCount}");

            Dictionary<int, int> frecuency = new Dictionary<int, int>();
            foreach (int element1 in arr2)
            {
                int count = 0;
                foreach (int element2 in arr2)
                    if (element1 == element2)
                        count++;
                frecuency.Add(element1, count);
            }
            Console.WriteLine("Частота вхождения каждого элемента в массив:");
            foreach (var item in frecuency)
                Console.WriteLine($"{item.Key} - {item.Value} раз");

            Console.ReadKey();
        }
    }
}
