using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BadPupil : Pupil
    {

        public override void Study()
        {
            Console.WriteLine("Учень навчається задовiльно");
        }

        public override void Read()
        {
            Console.WriteLine("Учень читає повiльно та без iнтонацiї");
        }

        public override void Write()
        {
            Console.WriteLine("Учень пише з великою кiлькiстю помилок");
        }

        public override void Relax()
        {
            Console.WriteLine("Учень гарно вiдпочиває");
        }
    }
}
