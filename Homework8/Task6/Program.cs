using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Calculate(in int x, in int y, in int z, out int result1, out int result2, out int result3)
        {
            result1 = x / 5;
            result2 = y / 5;
            result3 = z / 5;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введiть перше число: ");
            string number1 = Console.ReadLine();
            int x = int.Parse(number1);

            Console.WriteLine("Введiть друге число: ");
            string number2 = Console.ReadLine();
            int y = int.Parse(number2);

            Console.WriteLine("Введiть третє число: ");
            string number3 = Console.ReadLine();
            int z = int.Parse(number3);

          
            Calculate(in x, in y, in z, out int result1, out int result2, out int result3);

            Console.WriteLine($"Значення першого аргументу: {result1}, другого аргументу: {result2}, третього: {result3}");
            Console.ReadKey();

        }

    }
}
