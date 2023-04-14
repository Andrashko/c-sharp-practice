using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accountant accountant = new Accountant();
            Console.WriteLine("Лiкар: ");
            accountant.BonusPlus(Accountant.Post.Doctor, 103);

            Console.WriteLine();
            Console.WriteLine("Програмiст: ");
            accountant.BonusPlus(Accountant.Post.Programmer, 311);

            Console.WriteLine();
            Console.WriteLine("Вчитель: ");
            accountant.BonusPlus(Accountant.Post.Teacher, 112);

            Console.WriteLine();
            Console.WriteLine("Дизайнер: ");
            accountant.BonusPlus(Accountant.Post.Designer, 431);

            Console.ReadKey();
        }
        
    }
}
