using System;

// Статичні члени в абстрактних класах.

namespace Static
{
    class Program
    {
        static void Main()
        {
            AbstractClass instance = AbstractClass.CreateObject();
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
