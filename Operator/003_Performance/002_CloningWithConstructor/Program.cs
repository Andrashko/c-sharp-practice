using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

// Клонування із використанням конструктора.

namespace Cloning
{
    class MyClass : ICloneable
    {
        int a, b;

        public MyClass()
        {
            Thread.Sleep(1000);
            a = new Random().Next(1, 100);
            Thread.Sleep(1000);
            b = new Random().Next(1, 100);
        }

        public object Clone()
        {
            return new MyClass();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Stopwatch timer = new Stopwatch();

            // Вимірювання часу побудови оригіналу.

            timer.Start();
            MyClass original = new MyClass();
            timer.Stop();
            Console.WriteLine("original побудований за {0}", timer.Elapsed.Ticks);

            timer.Reset();

            // Замір часу побудови клону.

            timer.Start();
            MyClass clone = original.Clone() as MyClass;
            timer.Stop();
            Console.WriteLine("clone побудований за {0}", timer.Elapsed.Ticks);

            // Delay.
            Console.ReadKey();
        }
    }
}
