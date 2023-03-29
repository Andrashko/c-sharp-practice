using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Pupil
    {
        
        public virtual void Study()
        {
            Console.WriteLine("навчається");
        }

        public virtual void Read()
        {
            Console.WriteLine("читає");
        }

        public virtual void Write()
        {
            Console.WriteLine("пише");
        }

        public virtual void Relax()
        {
            Console.WriteLine("вiдпочиває");
        }

    }

}


