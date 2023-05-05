using System;
using System.Text;

// Базовий клас Object.

// Клонування асоціації відбувається поверхнево.

namespace ClassObject
{
    class A { public int a = 1; }
    class B { public int b = 2;  }
    class C { public B B = new B(); }

    class X
    {
        public A A = new A();
        public C C = new C();
    }

    class Program : X
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Program original = new Program();
            Console.WriteLine("Оригінал : " + original.A.a + " " + original.C.B.b);

            // Клонування об'єкту.
            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine("Клон : " + clone.A.a + " " + clone.C.B.b + "\n");

            // Перевірка на глибоке клонування.
            clone.A.a = clone.C.B.b = 7;

            Console.WriteLine("Оригінал : " + original.A.a + " " + original.C.B.b);
            Console.WriteLine("Клон : " + clone.A.a + " " + clone.C.B.b);

            // Delay.
            Console.ReadKey();
        }
    }
}
