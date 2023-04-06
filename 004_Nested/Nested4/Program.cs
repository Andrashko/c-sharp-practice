using System;

// Nested classes.

namespace Nested
{
    public class MyClass // Успадкування від BaseClass не поширюється.
    {
        public class Nested : BaseClass
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
            MyClass.Nested instance = new MyClass.Nested();

            instance.MethodFromBase();
            instance.MethodFromNested();

            // Delay.
            Console.ReadKey();
        }
    }
}
