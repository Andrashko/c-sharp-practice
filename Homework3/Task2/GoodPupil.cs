using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Учень навчається добре");
        }

        public override void Read()
        {
            Console.WriteLine("Учень читає без помилок, але могло б бути i краще");
        }

        public override void Write()
        {
            Console.WriteLine("Учень пише добре, але допускає незначнi помилки");
        }

        public override void Relax()
        {
            Console.WriteLine("Учень гарно вiдпочиває");
        }
    }
}
