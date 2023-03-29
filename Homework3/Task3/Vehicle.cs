using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Vehicle
    {
        private double coordinates;
        private double price;
        private int speed;
        private readonly int yearOfManufacture;

        public double Coordinates
        {
            get
            {
                return coordinates;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
        }

        public int YearOfManufacture
        {
            get
            {
                return yearOfManufacture;
            }
        }

        public Vehicle (double coordinates, double price, int speed, int yearOfManufacture)
        {
            this.coordinates = coordinates;
            this.price = price;
            this.speed = speed;
            this.yearOfManufacture = yearOfManufacture;
        }

        public void Show()
        {
            Console.WriteLine($"Координати:{coordinates}");
            Console.WriteLine($"Цiна: {price}$");
            Console.WriteLine($"Швидкiсть: {speed} км/год");
            Console.WriteLine($"Рiк випуску: {yearOfManufacture}");
        }
    }
}
