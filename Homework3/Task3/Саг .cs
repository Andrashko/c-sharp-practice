using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Саг : Vehicle
    {

        public Саг(double coordinates, double price, int speed, int yearOfManufacture)
            : base(coordinates, price, speed, yearOfManufacture)
        {
            Console.WriteLine(" ");
        }
        public void ShowCar()
        {
            
            Console.WriteLine("Машина");
            Console.WriteLine("");
            base.Show();

        }
    }
}
