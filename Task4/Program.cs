using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(100, "Yurii", "Visa");
            invoice.quantity = 10;
            Console.WriteLine($"Cost Without VAT: {invoice.CalculateCostWithoutVAT()}");
            Console.WriteLine($"Cost With VAT: {invoice.CalculateCostWithVAT()}");
            Console.ReadLine();
        }
    }
}
