using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть текст: ");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(new string('*',20));
            Console.WriteLine();

            Console.Write("Оберiть зi списку колiр та введiть вiдповiдний номер:\n1.Синiй\n2.Бiлий\n3.Чорний\n4.Червоний\n5.Зелений\n6.Жовтий\n7.Смарагдовий\n\nНОМЕР:  ");
            int selectedColor = int.Parse(Console.ReadLine());

            if (selectedColor < 1 || selectedColor > 7)
            {
                Console.WriteLine("Вибачте, такого кольору немає :( ");
                return;
            }

            ColorfulLife.UsersColor color = (ColorfulLife.UsersColor)(selectedColor - 1);
            ColorfulLife.Print(text, color);

            Console.ReadKey();
        }
    }
}
