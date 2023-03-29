using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ збережений у новому форматi");
        }
    }
}
