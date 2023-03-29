using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Клас з 4 різними учнями");
            ClassRoom classRoom1 = new ClassRoom(
                    new ExcelentPupil(),
                    new GoodPupil(),
                    new BadPupil(),
                    new Pupil()
                );
            classRoom1.Study();
            classRoom1.Read();
            classRoom1.Write();
            classRoom1.Relax();
            Console.WriteLine("Клас з 2 відмінниками");
            ClassRoom classRoom2 = new ClassRoom(
                new ExcelentPupil(),
                new ExcelentPupil()
                );
            classRoom2.Study();
            classRoom2.Read();
            classRoom2.Write();
            classRoom2.Relax();




            Console.ReadKey();
        }
    }
}
