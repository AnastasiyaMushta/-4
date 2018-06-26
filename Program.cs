using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 1.2;// Начало отрезка
            double x1 = 1.3;// Конец отрезка
            double x; // корень
            double e;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задание 4");
            Console.ResetColor();
            //точный ввод Е
            Console.Write("Введите точность E:\n");
            while ((!Double.TryParse(Console.ReadLine(), out e)) || (e > 1) || (e < 0))
                Console.WriteLine("Введите число в промежутке строго от 0 до 1!");

            //вычисление с помощью метода хорд 
            do
            {
                x = x1;
                x1 = x1 - (F(x1) * (x1 - x0) / (F(x1) - F(x0)));
            } while (Math.Abs(x - x1) > e);

            //печать найденного корня
            Console.WriteLine("Корень уравнения в промежутке: " + x1);
            Console.ReadKey();
        }

        /// <summary>
        /// Значение функции в точке x
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double F(double x)
        {
            return (4 + Math.Pow(x, 2)) * (Math.Pow(Math.E, x) - Math.Pow(Math.E, -x)) - 18;
        }
    }
}

