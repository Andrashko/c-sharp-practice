using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ClassRoom
    {
        private Pupil pupil1;
        private Pupil pupil2;
        private Pupil pupil3;
        private Pupil pupil4;

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
            : this(pupil1, pupil2, pupil3, new BadPupil())
        {
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
            : this(pupil1, pupil2, new BadPupil(), new BadPupil())
        {
        }

        public void Study()
        {
            pupil1.Study();
            pupil2.Study();
            pupil3.Study();
            pupil4.Study();
        }

        public void Read()
        {
            pupil1.Read();
            pupil2.Read();
            pupil3.Read();
            pupil4.Read();
        }

        public void Write()
        {
            pupil1.Write();
            pupil2.Write();
            pupil3.Write();
            pupil4.Write();
        }

        public void Relax()
        {
            pupil1.Relax();
            pupil2.Relax();
            pupil3.Relax();
            pupil4.Relax();
        }

        public ClassSwitch
            {
}
    }

  
        

}

