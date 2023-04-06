using System;

// Статический конструктор.

namespace Static
{
    class Program
    {
        static void Main()
        {
            // 1 Варіант. (Викликається лише Статичний конструктор.)
            //NotStaticClass.StaticMethod();

            // 2 Варіант. (Викликаються обидва конструктори.)
            new NotStaticClass().NotStaticMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
