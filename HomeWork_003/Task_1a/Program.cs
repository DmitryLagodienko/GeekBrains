using System;

namespace Task_1a
{
    /*
     1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры

    Лагодиенко Дмитрий
    */
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Console.WriteLine($"Комплексное число 1: {complex1.ToString()}");
            Console.WriteLine($"Комплексное число 2: {complex2.ToString()}");
            Complex result = complex1.Minus(complex2);
            Console.WriteLine($"Разница чисел: {result.ToString()}");
            Console.ReadKey();
        }
    }

    struct Complex
    {
        public double re;
        public double im;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }
        //  Вычитание
        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;
            return y;
        }

        public string ToString()
        {
            if (im < 0)
                return $"{re} + ({im})i";
            else
                return $"{re} + {im}i";
        }
    }
}
