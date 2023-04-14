using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        Func<double, double, double, double> average = delegate (double a, double b, double c)
        {
            return (a + b + c) / 3;
        };

        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Введiть перше число:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть друге число:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть друге число:");
            double number3 = double.Parse(Console.ReadLine());

            
            double result = program.average(number1, number2, number3);
            Console.WriteLine($"Середнє арифметичне чисел {number1}, {number2} та {number3} дорiвнює {result}");

            Console.ReadKey();
        }
    }
}
