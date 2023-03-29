using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ClassRoom
    {
        private Pupil[] pupils;
        private const int COUNT = 4;      
     
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
            : this(pupil1, pupil2, pupil3)
        {
            pupils[3] = pupil4;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
            : this(pupil1, pupil2)
        {
            pupils[2] = pupil3;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils = new Pupil[COUNT];  
            pupils[0] = pupil1;
            pupils[1] = pupil2;
        }

        public void Study()
        {
            for (int i = 0;i<COUNT; i++)
            {
                if (pupils[i] == null)
                    break;
                pupils[i].Study();
            }
        }

        public void Read()
        {
            for (int i = 0; i < COUNT; i++)
            {
                if (pupils[i] == null)
                    break;
                pupils[i].Read();
            }
        }

        public void Write()
        {
            for (int i = 0; i < COUNT; i++)
            {
                if (pupils[i] == null)
                    break;
                pupils[i].Write();
            }
        }

        public void Relax()
        {
            for (int i = 0; i < COUNT; i++)
            {
                if (pupils[i] == null)
                    break;
                pupils[i].Relax();
            }
        }

    }

  
        

}

