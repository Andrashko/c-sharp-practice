using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ вiдредаговано");
        }

        public override void EditDocument()
        {
            Console.WriteLine("Документ збережено у старому форматi");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Збереження в iнших форматах є у версiї Експерт");
        }
    }
}
