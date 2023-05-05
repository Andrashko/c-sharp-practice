using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

// Клонування за допомогою MemberwiseClone().

// Перевага клонування з використанням MemberwiseClone() у тому, що
// При клонуванні не викликається конструктор, а клонування відбувається через
// Копіювання дампа пам'яті - тіла оригіналу.

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
            return this.MemberwiseClone();
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

            // Вимірювання часу побудови клону.

            timer.Start();
            MyClass clone = original.Clone() as MyClass;
            timer.Stop();
            Console.WriteLine("clone побудований за {0}", timer.Elapsed.Ticks);

            // Delay.
            Console.ReadKey();
        }
    }
}
