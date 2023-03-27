using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(38.65, 41.57, 8.916);
            Console.WriteLine("Введiть, будь ласка, потрiбну суму для обмiну: ");      
            int countForChange = Convert.ToInt32(Console.ReadLine());

            double usd = converter.ConvertUAHtoUSD(countForChange);
            double eur = converter.ConvertUAHtoEUR(countForChange);
            double pln = converter.ConvertUAHtoPLN(countForChange);

            double uan1 = converter.ConvertUSDtoUAH(countForChange);
            double uan2 = converter.ConvertEURtoUAH(countForChange);
            double uan3 = converter.ConvertPLNtoUAH(countForChange);

            Console.WriteLine($"\nВаша сума {countForChange} грн\n\nUSD: {usd}\nEUR: {eur}\nPLN: {pln}");

            Console.WriteLine($"\nПереведення в грн:\n\n{countForChange}$: {uan1}\n{countForChange}€: {uan2}\n{countForChange}zł: {uan3}");

            Console.ReadKey();

        }
    }
}
