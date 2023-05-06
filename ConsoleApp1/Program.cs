using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        /*
         * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
            Уявіть, що ви пишете додаток для Автостанції та вам необхідно створити
            просту колекцію автомобілів з
            наступними даними: марка автомобіля, модель, рік випуску, колір.    
            А також другу колекцію з моделлю
            автомобіля, ім'ям покупця і його номером телефону.
            Використовуючи найпростіший LINQ запит, виведіть на екран інформацію про покупця одного з
            автомобілів і повну характеристику придбаної їм моделі.
         *
         *
         */
        static void Main(string[] args)
        {
            var carCollection = new[] {
                new {
                    Mark = "BMW",
                    Model = "X5",
                    Year = 2020,
                    Color = "Black"
                },
                new
                {
                    Mark = "Shkoda",
                    Model = "Octavia",
                    Year = 2010,
                    Color = "Blue"
                }
            };

            var byerCollection = new[]
            {
                new
                {
                    Model = "Octavia",
                    Name = "Yurii",
                    Phone = "+38050"
                },
                new
                {
                    Model = "Fabia",
                    Name = "Ivan",
                    Phone = "+38067"
                },

            };

            /*foreach (var car in carCollection)
            {
                Console.WriteLine(car);
            }
            */
            foreach (var byer in byerCollection)
            {
                Console.WriteLine(byer);
                var car = carCollection.Where(car => car.Model == byer.Model)
                    .FirstOrDefault();


                if (car != null)
                {
                    Console.WriteLine(car);
                }
                else
                {
                    Console.WriteLine("Не знайдено");
                }
                
            }
            Console.ReadLine();
        }

       // static private dynamic byer;
       // static bool CheckCar(dynamic car)
       // {
       //     return car.Model == byer.Model;
       // }
    }
}
