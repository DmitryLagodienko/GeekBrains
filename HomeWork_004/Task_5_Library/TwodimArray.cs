using System;
using System.IO;

namespace Task_5_Library
{
    //  * а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать
    //  конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают
    //  сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство,
    //  возвращающее минимальный элемент массива, свойство, возвращающее максимальный
    //  элемент массива, метод, возвращающий номер максимального элемента массива(через
    //  параметры, используя модификатор ref или out).
    //
    //  ** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные
    //  в файл.
    //
    //  ** в) Обработать возможные исключительные ситуации при работе с файлами
    //
    //  Лагодиенко Дмитрий
    public class TwodimArray
    {
        private int[,] _arr;

        public TwodimArray(int rows, int columns)
        {
            _arr = new int[rows, columns];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                _arr[i,j] = rand.Next();
        }
        
        public TwodimArray(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                int rows = Convert.ToInt32(sr.ReadLine());
                int columns = Convert.ToInt32(sr.ReadLine());
                _arr = new int[rows, columns];
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                        _arr[i, j] = Convert.ToInt32(sr.ReadLine());
                sr.Close();
            }
            catch
            {
                Console.WriteLine($"Не удалось загрузить файл \"{fileName}\"");
            }
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int element in _arr)
                sum += element;
            return sum;
        }

        public int Sum(int n)
        {
            int sum = 0;
            foreach (int element in _arr)
                if (element > n)
                    sum += element;
            return sum;
        }

        public int Max 
        {
            get
            {
                int max = _arr[0, 0];
                foreach (int element in _arr)
                    if (element > max)
                        max = element;
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = _arr[0, 0];
                foreach (int element in _arr)
                    if (element < min)
                        min = element;
                return min;
            }
        }

        public void GetMaxElementIndex(ref int row, ref int column)
        {
            int max = _arr[0, 0];
            for (int i = 0; i < _arr.GetLength(0); i++)
                for (int j = 0; j < _arr.GetLength(1); j++)
                    if (max < _arr[i, j])
                    {
                        max = _arr[i, j];
                        row = i;
                        column = j;
                    }

        }
        public void WriteArrInFile(string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName);
                foreach (int element in _arr)
                    sw.WriteLine(element);
                sw.Close();
            }
            catch
            {
                Console.WriteLine($"Не удалось записать массив в файл \"{fileName}\"");
            }
        }
    }
}
