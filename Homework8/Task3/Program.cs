using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Введiть кiлькiсть клiєнтiв: ");
            int n = int.Parse(Console.ReadLine());


            int result = deliveryRoutes(n);
            Console.WriteLine("Кiлькiсть маршрутiв: " + result);
            Console.ReadKey();

        }

        static int deliveryRoutes(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * deliveryRoutes(n - 1);

        }
    }
}
