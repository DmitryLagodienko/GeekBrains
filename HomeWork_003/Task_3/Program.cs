using System;

namespace Task_3
{
    /*
     3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    Написать программу, демонстрирующую все разработанные элементы класса.
    * Добавить свойства типа int для доступа к числителю и знаменателю;
    * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    *** Добавить упрощение дробей.

    Задания с ** и *** не сделал(

    Лагодиенко Дмитрий
    */
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int denom;
            num = GetInput("Числитель первой дроби: ");
            denom = GetInput("Знаменатель первой дроби: ");
            Fraction x = new Fraction(num, denom);
            num = GetInput("Числитель второй дроби: ");
            denom = GetInput("Знаменатель второй дроби: ");
            Fraction y = new Fraction(num, denom);

            Console.WriteLine($"1 дробь: {x.Num}/{x.Denom}");
            Console.WriteLine($"2 дробь: {y.Num}/{y.Denom}");
            Fraction z = x.Plus(y);
            Console.WriteLine($"\nСумма: {z.Num}/{z.Denom}");
            z = x.Minus(y);
            Console.WriteLine($"Разница: {z.Num}/{z.Denom}");
            z = x.Multi(y);
            Console.WriteLine($"Произведение: {z.Num}/{z.Denom}");
            z = x.Division(y);
            Console.WriteLine($"Частное: {z.Num}/{z.Denom}");
            Console.WriteLine($"Десятичное представление дроби: {z.Decimal}");
            Console.ReadKey();
        }

        private static int GetInput(string message)
        {
            int number;
            bool isNum;
            do
            {
                Console.Write(message);
                isNum = int.TryParse(Console.ReadLine(), out number);
            } while (!isNum);
            return number;
        }

        static int FindDivisible(int x, int y)
        {
            int divisible;
            if (x > y)
                divisible = x;
            else
                divisible = y;
            for (int i = 1; divisible % x != 0 || divisible % y != 0; i++)
                divisible *= i;
            return divisible;
        }

        class Fraction
        {
            public int Num { get; private set; }
            public int Denom { get; private set; }
            public double Decimal { get; private set; }

            public Fraction(int n, int d)
            {
                Num = n;
                Denom = d;
                Decimal = Convert.ToDouble(Num) / Denom;
            }
            //  Сложение
            public Fraction Plus(Fraction x)
            {
                int divisible = FindDivisible(Denom, x.Denom);
                int num = Num * divisible / Denom + x.Num * divisible / x.Denom;
                int denom = divisible;
                return new Fraction(num, denom);
            }
            //  Вычитание
            public Fraction Minus(Fraction x)
            {
                int divisible = FindDivisible(Denom, x.Denom);
                int num = Num * divisible / Denom - x.Num * divisible / x.Denom;
                int denom = divisible;
                return new Fraction(num, denom);
            }
            //  Умножение
            public Fraction Multi(Fraction x)
            {
                int num = Num * x.Num;
                int denom = Denom * x.Denom;
                return new Fraction(num, denom);
            }
            //  Деление
            public Fraction Division(Fraction x)
            {
                int num = Num * x.Denom;
                int denom = Denom * x.Num;
                return new Fraction(num, denom);
            }
        }
    }
}
