using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_5._1_Console
{
    internal class Program
    {
        static void Function(double x)
        {
            x = Math.Round(x, 2);
            try
            {
                if (x * x - 1 < 0) throw new Exception($"При x = {Math.Round(x, 2)} функция не определена!");
                Console.Write(Math.Sqrt(x * x - 1));
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            double a, b, h;

            Console.Write("Введите левую границу а: ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.Write("Введено недопустимое значение! К вводу доступны цифры, знак \"минус\" и запятая" +
                                  "\nВведите левую границу а: ");

            Console.Write("Введите правую границу b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.Write("Введено недопустимое значение! К вводу доступны цифры, знак \"минус\" и запятая" +
                                  "\nВведите правую границу b: ");

            Console.Write("Введите шаг h: ");
            while (!double.TryParse(Console.ReadLine(), out h))
                Console.Write("Введено недопустимое значение! К вводу доступны цифры, знак \"минус\" и запятая" +
                                  "\nВведите шаг h: ");

            Console.WriteLine("Таблица значений: ");
            Console.WriteLine("x\t|y\t"); Console.WriteLine("==================");
            for (double x = a; x <= b; x += h)
            {
                Console.Write($"{Math.Round(x, 2)}\t|"); 
                Function(x); 
                Console.WriteLine();
            }
        }
    }
}
