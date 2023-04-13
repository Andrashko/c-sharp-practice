using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> add = (x, y) => x + y;
            Func<double, double, double> sub = (x, y) => x - y;
            Func<double, double, double> mul = (x, y) => x * y;
            Func<double, double, double> div = (x, y) => y == 0 ? throw new DivideByZeroException() : x / y;

            Console.WriteLine("Введiть перше число:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть друге число:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть дію (+, -, *, /):");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат: {add(number1, number2)}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {sub(number1, number2)}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {mul(number1, number2)}");
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine($"Результат: {div(number1, number2)}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Дiлення на нуль не можна!");
                    }
                    break;
                default:
                    Console.WriteLine("Невiрна операцiя");
                    break;
            }

            Console.ReadLine();
        }
    }
}
