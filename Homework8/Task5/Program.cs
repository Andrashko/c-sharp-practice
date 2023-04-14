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
            Console.Write("Будь ласка, введiть дату свого народження (yyyy/mm/dd): ");
            DateTime myBirthday = DateTime.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime nextBirthday = myBirthday.AddYears(today.Year - myBirthday.Year);


            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            int daysUntilNextBirthday = (nextBirthday - today).Days;


            Console.WriteLine();
            Console.WriteLine($"До Вашого дня народження залишилося {daysUntilNextBirthday} днiв");
            Console.ReadKey();
        }
    }
}
