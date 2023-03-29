using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Plane : Vehicle
    {
        private int height;
        private int numberOfPassengers;


        public double Height
        {
            get
            {
                return height;
            }
        }

        public double NumberOfPassengers
        {
            get
            {
                return numberOfPassengers;
            }
        }

        public Plane (double coordinates, double price, int speed, int yearOfManufacture, int height, int numberOfPassengers)
            : base(coordinates, price, speed, yearOfManufacture)
        {
            this.height = height;
            this.numberOfPassengers = numberOfPassengers;
        }

        public void ShowPlane()
        {
            
            Console.WriteLine("Лiтак");
            Console.WriteLine($"\nВисота: {height} над р.м.");
            Console.WriteLine($"Кiлькiсть пасажирiв: {numberOfPassengers}");
            base.Show();
        }
    }
}
