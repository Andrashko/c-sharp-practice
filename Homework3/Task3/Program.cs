using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Plane plane = new Plane(3421, 34000, 1285, 2022, 32564, 300);
            plane.ShowPlane();

            Console.WriteLine();
            Console.WriteLine(new string('*', 20));
            Console.WriteLine();

            Ship ship = new Ship(2378, 24070, 53, 2020, 200, "NFS");
            ship.ShowShip();

            Console.WriteLine();
            Console.WriteLine(new string('*', 20));

            Саг car = new Саг(678, 3000, 150, 2018);
            car.ShowCar();

            Console.ReadKey();
        }
    }
}
