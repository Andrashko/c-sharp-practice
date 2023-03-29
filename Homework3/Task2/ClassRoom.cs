using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ClassRoom
    {
        private List<Pupil> pupils;
        private const int COUNT = 4;      
     
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
            : this(pupil1, pupil2, pupil3)
        {
            pupils.Add ( pupil4);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
            : this(pupil1, pupil2)
        {
            pupils.Add(pupil3);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils = new List<Pupil> { pupil1, pupil2 };    
        }

        public void Study()
        {
            for (int i = 0; i<pupils.Count; i++)
            {
                pupils[i].Study();
            }
        }

        public void Read()
        {
            for (int i = 0; i < pupils.Count; i++)
            {
                pupils[i].Read();
            }
        }

        public void Write()
        {
            for (int i = 0; i < pupils.Count; i++)
            {
                pupils[i].Write();
            }
        }

        public void Relax()
        {
            for (int i = 0; i < pupils.Count; i++)
            {
                pupils[i].Relax();
            }
        }

    }

  
        

}

