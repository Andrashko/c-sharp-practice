using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учень навчається успiшно");
        }

        public override void Read()
        {
            Console.WriteLine("Учень чудово читає");
        }

        public override void Write()
        {
            Console.WriteLine("Учень пише на вiдмiнно");
        }

        public override void Relax()
        {
            Console.WriteLine("Учень гарно вiдпочиває");
        }
    }
}
