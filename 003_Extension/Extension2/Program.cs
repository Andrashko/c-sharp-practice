using System;

// Розширюючі методи. (Extension methods)

// Аргумент розширення завжди має бути лише один і стояти першим у списку аргументів.

namespace Extension
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }
    }

    class Program
    {
        static void Main()
        {
            string text = "Hello ";
                        
            text.ExtensionMethod("world!");
            
            // Delay.
            Console.ReadKey();
        }
    }
}
