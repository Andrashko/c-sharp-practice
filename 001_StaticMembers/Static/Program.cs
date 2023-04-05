using System;

// Статичні члени у нестатичних класах.

namespace Static
{
    class Program
    {
        static void Main()
        {
            NotStaticClass instance1 = new NotStaticClass(1);
            NotStaticClass instance2 = new NotStaticClass(2);

            instance1.Method();
            instance2.Method();

            // На класі-об'єкті NotStaticClass, звертаємось до статичного поля - field
            NotStaticClass.field = 1;

            instance1.Method();
            instance2.Method(); 

            // Delay.
            Console.ReadKey();
        }
    }
}
