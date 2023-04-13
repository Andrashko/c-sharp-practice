using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Accountant
    {
        public enum Post
        {
            Teacher = 300,
            Doctor = 200,
            Designer = 300,
            Programmer = 267
        }

        public bool BonusPlus(Post worker, int hours)
        {
            int workedHours = (int)worker;
            if (hours > workedHours)
            {
                Console.WriteLine("+ Надати премiю працiвнику");
                return true;
            }
            else
            {
                Console.WriteLine("- Премiя у працiвника вiдсутня :(");
                return false;
            }

        }
    }
}
