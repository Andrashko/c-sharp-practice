using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class DocumentWorker
    {

        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ вiдкритий");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа у версiї Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа у версiї Про");
        }
    }
}
