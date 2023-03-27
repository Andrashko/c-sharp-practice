using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(235, "Юрiй", "Visa");
            invoice.quantity = 5;
            Console.WriteLine($"Введiть товар: ");
            string _article = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"Цiна без ПДВ: {invoice.CalculateCostWithoutVAT()}");
            Console.WriteLine($"Цiна з ПДВ: {invoice.CalculateCostWithVAT()}");
            Console.ReadLine();
        }
    }
}
