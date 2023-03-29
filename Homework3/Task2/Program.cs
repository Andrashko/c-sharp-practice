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
            Pupil pupil1 = new ExcelentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new BadPupil();
            Pupil pupil4 = new BadPupil();

            Console.WriteLine("Оберіть учня:");
            Console.WriteLine("1. Джон");
            Console.WriteLine("2. Марія");
            Console.WriteLine("3. Пітер");
            Console.WriteLine("4. Ліза");
            

            string input = Console.ReadLine();

            ClassRoom classRoom = null;
            switch (input)
            {
                case "1":
                    classRoom = new ClassRoom(pupil1, pupil1);
                    break;
                case "2":
                    classRoom = new ClassRoom(pupil2, pupil2);
                    break;
                case "3":
                    classRoom = new ClassRoom(pupil3, pupil3);
                    break;
                case "4":
                    classRoom = new ClassRoom(pupil4, pupil4);
                    break;
                
                default:
                    Console.WriteLine("Не вiрний ввiд");
                    return;
            }

            if (classRoom != null)
            {
                classRoom.Study();
                classRoom.Read();
                classRoom.Write();
                classRoom.Relax();
            }

            Console.ReadKey();
        }
    }
}
