using System;

namespace Static
{
    class NotStaticClass
    {
        // Контруктор екземпляру викликається тільки при створенні екземпляра класу.
        public NotStaticClass()
        {
            Console.WriteLine("Instance Constructor.");
        }

        // Статичний конструктор викликається у будь-якому випадку,
        // як з звернення до статичного члену та під час створення екземпляру класу.
        static NotStaticClass()
        {
            Console.WriteLine("Static Constructor.");
        }

        // Статичний метод.
        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
        }

        public void NotStaticMethod()
        {
            Console.WriteLine("NotStaticMethod");
        }
    }
}
