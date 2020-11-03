using System;

namespace Task_1c
{
    /*
     1. б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.

    Лагодиенко Дмитрий
    */
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(1, 5);
            Complex complex2 = new Complex(3, 3);
            Complex result;

            Console.WriteLine($"Комплексное число 1: {complex1.ToString()}");
            Console.WriteLine($"Комплексное число 2: {complex2.ToString()}");

            Console.WriteLine("\nЧтобы увидеть сумму, введите: plus");
            Console.WriteLine("Чтобы увидеть разницу, введите: minus");
            Console.WriteLine("Чтобы увидеть произведение, введите: multi");
            Console.WriteLine("Чтобы выйти, введите: exit");

            string userInput;
            do
            {
                Console.Write("\nВведите команду: ");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "plus":
                        result = complex1.Plus(complex2);
                        Console.WriteLine($"Сумма: {result.ToString()}");
                        break;
                    case "minus":
                        result = complex1.Minus(complex2);
                        Console.WriteLine($"Разница: {result.ToString()}");
                        break;
                    case "multi":
                        result = complex1.Multi(complex2);
                        Console.WriteLine($"Произведение: {result.ToString()}");
                        break;
                    default:
                        break;
                }
            } while (userInput != "exit");
        }
    }

    class Complex
    {
        private double _im;
        private double _re;

        public Complex()
        {
            _re = 0;
            _im = 0;
        }

        public Complex(double im, double re)
        {
            _im = im;
            _re = re;
        }
        //  Вычитание
        public Complex Minus(Complex x)
        {
            Complex y = new Complex();
            y._re = _re - x._re;
            y._im = _im - x._im;
            return y;
        }
        //  Сложение
        public Complex Plus(Complex x)
        {
            Complex y = new Complex();
            y._re = _re + x._re;
            y._im = _im + x._im;
            return y;
        }
        //  Умножение
        public Complex Multi(Complex x)
        {
            Complex y = new Complex();
            y._re = (_re * x._re - _im * x._im);
            y._im = (_im * x._re + _re * x._im);
            return y;
        }

        public string ToString()
        {
            if (_im < 0)
                return $"{_re} + ({_im})i";
            else
                return $"{_re} + {_im}i";
        }
    }
}
