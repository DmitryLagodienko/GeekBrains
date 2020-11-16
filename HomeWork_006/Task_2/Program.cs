using System;
using System.Collections.Generic;
using System.IO;

namespace Task_2
{
    //  Модифицировать программу нахождения минимума функции так,
    //  чтобы можно было передавать функцию в виде делегата.
    //  а) Сделайте меню с различными функциями и предоставьте пользователю выбор,
    //  для какой функции и на каком отрезке находить минимум.
    //  б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
    //  в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
    //  возвращает минимум через параметр (с использованием модификатора out).
    //
    //  Лагодиенко Дмитрий

    public delegate double Fun(double x);

    class Program
    {
        public static double MyFuncSquare(double x)
        {
            return x * x;
        }

        public static double MyFuncSin(double x)
        {
            return Math.Sin(x);
        }

        public static double MyFuncCos(double x)
        {
            return Math.Cos(x);
        }

        public static void SaveFunc(string fileName, Fun f, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += h;
            }
            Console.WriteLine();
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double[] values = new double[fs.Length / sizeof(double)];
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                values[i] = bw.ReadDouble();
                if (values[i] < min)
                    min = values[i];
            }
            bw.Close();
            fs.Close();
            return values;
        }

        public static void ChooseFunc(out int index, out double a, out double b, out double h)
        {
            string userInput;
            Console.WriteLine("Выберите функцию:\n\t   X^2 - введите 0\n\tSin(X) - введите 1\n\tCos(X) - введите 2\n");
            do
            {
                Console.Write("Ваш выбор: ");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out index) || index < 0 || index > 2);

            do
            {
                Console.Write("Введите начало отрезка. A = ");
                userInput = Console.ReadLine();
            } while (!double.TryParse(userInput, out a));

            do
            {
                Console.Write("Введите конец отрезка.  B = ");
                userInput = Console.ReadLine();
            } while (!double.TryParse(userInput, out b));

            do
            {
                Console.Write("Введите шаг функции.    h = ");
                userInput = Console.ReadLine();
            } while (!double.TryParse(userInput, out h) || h == 0);
        }

        static void Main(string[] args)
        {
            List<Fun> fun = new List<Fun>();
            fun.Add(MyFuncSquare);
            fun.Add(MyFuncSin);
            fun.Add(MyFuncCos);

            int index;
            double a, b, h;
            ChooseFunc(out index, out a, out b, out h);
            SaveFunc("data.bin", fun[index], a, b, h);
            double min;
            double[] values = Load("data.bin", out min);
            Console.WriteLine("Значения функции:");
            for (int i = 0; i < values.Length; i++)
                Console.Write(values[i] + " ");
            Console.WriteLine($"\nМинимум функции: {min}");
            Console.ReadKey();
        }
    }
}
