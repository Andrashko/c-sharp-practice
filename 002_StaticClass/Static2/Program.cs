using System;

// Паттерн проектування - Singleton.

namespace Static
{
    class Program
    {
        static void Main()
        {
            // Конструктор "protected" - неможливо використовувати - new Singleton() 
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            if (instance1 == instance2)
                Console.WriteLine("Посилання вказують на один екземпляр об'єкта.");            
            
            // Delay.
            Console.ReadKey();
        }
    }
}
