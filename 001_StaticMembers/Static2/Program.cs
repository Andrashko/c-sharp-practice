using System;

// Статичні члени у нестатичних класах.

namespace Static
{
    class Program
    {
        static void Main()
        {
            NotStaticClass instance = new NotStaticClass(1);


            NotStaticClass.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
