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
            Printer printer = new Printer();
            printer.Print("Колiр за замовчуванням");

            ColorPrinter colorPrinter = new ColorPrinter();
            colorPrinter.Print("Синій колiр");

            BlackWhitePrinter blackWhitePrinter = new BlackWhitePrinter();
            blackWhitePrinter.Print("Сiрий колiр");

            Console.ReadKey();
        }
    }
}
