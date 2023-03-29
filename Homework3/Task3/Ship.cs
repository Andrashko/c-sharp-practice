using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Ship : Vehicle
    {

        private int passengerCount;
        private string port;

        public int PassengerCount
        {
            get
            {
                return passengerCount;
            }
        }

        public string Port
        {
            get
            {
                return port;
            }
        }

        public Ship (double coordinates, double price, int speed, int yearOfManufacture, int passengerCount, string port)
            : base(coordinates, price, speed, yearOfManufacture)

        {
            this.passengerCount = passengerCount;
            this.port = port;
        }

        public void ShowShip()
        {
            
            Console.WriteLine("Корабель");
            Console.WriteLine($"\nКiлькiсть пасажирiв: {passengerCount}");
            Console.WriteLine($"Порт: {port}");
            base.Show();
        }
    }
}

