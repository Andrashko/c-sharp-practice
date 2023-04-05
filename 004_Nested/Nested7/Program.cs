using System;

// Nested classes.

// Нестатичні класи можуть містити статичні Nested класи.

namespace Nested
{
    public class MyClass
    {
        public static class Nested
        {
            public static void StaticMethodFromNested()
            {
                Console.WriteLine("Статичний метод Nested класу.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass.Nested.StaticMethodFromNested();

            // Delay.
            Console.ReadKey();
        }
    }
}
