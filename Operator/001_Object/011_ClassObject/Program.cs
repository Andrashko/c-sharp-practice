using System;
using System.Text;

// Базовий клас Object.

// Граф наслідування клонується глибоко.

namespace ClassObject
{
    class A { public int a = 1; }
    class B : A { public int b = 2; }
    class C : B { public int c = 3; }
    class X : C { }

    class Program : X
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Program original = new Program();
            Console.WriteLine("Оригінал : " + original.a + " " + original.b + " " + original.c);

            // Клонування об'єкту. 
            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine("Клон : " + clone.a + " " + clone.b + " " + clone.c + "\n");

            // Перевірка на глибоке клонування.
            clone.a = clone.b = clone.c = 7;

            Console.WriteLine("Оригінал : " + original.a + " " + original.b + " " + original.c);
            Console.WriteLine("Клон : " + clone.a + " " + clone.b + " " + clone.c);

            // Delay.
            Console.ReadKey();
        }
    }
}
