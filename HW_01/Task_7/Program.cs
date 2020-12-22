using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.С клавиатуры вводятся числовые координаты двух полей шахматной доски (x1, y1, x2, y2). Требуется
//  определить, относятся ли к поля к одному цвету или нет.

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            while (true)
            {
                Console.WriteLine("Введите координаты первого поля шахматной доски");
                x1 = CharEnter();
                y1 = NumEnter();
                Console.WriteLine("Введите координаты второго поля шахматной доски");
                x2 = CharEnter();
                y2 = NumEnter();

                if ((x1 + y1) % 2 == (x2 + y2) % 2)
                    Console.WriteLine("Эти поля одного цвета\n");
                else
                    Console.WriteLine("Эти поля разных цветов\n");
                Console.ReadKey();
            }
        }

        static int CharEnter()
        {
            string userInput;
            int x = 0;
            while (x == 0)
            {
                Console.Write("Буква (a - h): ");
                userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "a":
                        x = 1;
                        break;
                    case "b":
                        x = 2;
                        break;
                    case "c":
                        x = 3;
                        break;
                    case "d":
                        x = 4;
                        break;
                    case "e":
                        x = 5;
                        break;
                    case "f":
                        x = 6;
                        break;
                    case "g":
                        x = 7;
                        break;
                    case "h":
                        x = 8;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
            return x;
        }

        static int NumEnter()
        {
            int y = 0;
            bool isNum;
            while (y == 0)
            {
                Console.Write("Цифра (1 - 8): ");
                isNum = int.TryParse(Console.ReadLine(), out y);
                if (!(isNum && y >= 1 && y <= 8))
                {
                    Console.WriteLine("Неверный ввод");
                    y = 0;
                }
            }
            return y;
        }
    }
}
