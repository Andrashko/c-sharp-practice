using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть ключ (pro або exp): ");
            string key = Console.ReadLine();

            DocumentWorker document;

            if (key == "pro")
            {
                document = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                document = new ExpertDocumentWorker();
            }
            else
            {
                document = new DocumentWorker();
            }

            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

            Console.ReadKey();
        }
    }
}
