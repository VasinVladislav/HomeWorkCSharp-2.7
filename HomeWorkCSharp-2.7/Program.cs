using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
            Console.Write("Программа для нахождения среднего арифметического и геометрического числа.\nВведите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            double A = (x + y) / 2;
            double G = Math.Sqrt(x * y);
            Console.WriteLine($"Ответ:\nа) Среднее арифметическое чисел {x} и {y} равно: {A.ToString("#.##")}" +
                $"\nб) Среднее геометрическое чисел {x} и {y} равно: {G.ToString("#.##")}");
        }
    }
}
