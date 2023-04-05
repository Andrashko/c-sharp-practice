using System;

// Nested classes.

namespace Nested
{
    public class MyClass : BaseClass 
    {
        public class Nested // Успадкування від BaseClass не поширюється.
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Метод Nested класу.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance1 = new MyClass();
            instance1.MethodFromBase();

            MyClass.Nested instance2 = new MyClass.Nested();
            instance2.MethodFromNested();

            // Delay.
            Console.ReadKey();
        }
    }
}
