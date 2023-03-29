using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Printer
    {
        private string value;

        public string Value
        {
            get
            {
                return value;
            }
        }

        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
