using System;

// Nested classes.

// Статичні класи можуть містити нестатичні Nested класи.

namespace Nested
{
    public static class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Статичний конструктор MyClass");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Статичний метод класу MyClass");
        }

        public class Nested
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
            instance.MethodFromNested();

            Console.WriteLine(new string('-', 30));

            MyClass.StaticMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
