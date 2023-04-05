using System;

// Nested classes.

namespace Nested
{
    class MyClass
    {
        public class Nested
        {
            public void Method()
            {
                Console.WriteLine("Метод з Nested класу");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass.Nested instance = new MyClass.Nested();

            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
