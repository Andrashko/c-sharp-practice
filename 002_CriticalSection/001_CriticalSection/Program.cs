using System;
using System.Text;
using System.Threading;

// Критична секція (critical section).

// lock - блокує блок коду так, що в кожен окремий момент часу цей блок коду
// зможе використовувати лише один потік. Всі інші потоки чекають поки що поточний потік, закінчить роботу.

namespace CriticalSection
{
    class MyClass
    {
        object block = new object();

        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();

            lock (block) // Закоментувати lock.
            {
                for (int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine($"Поток # {hash}: крок { counter}");
                    Thread.Sleep(100);
                }
                Console.WriteLine(new string('-', 20));                
            }
        }

        class Program
        {
            static void Main()
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.SetWindowSize(40, 20);

                MyClass instance = new MyClass();

                for (int i = 0; i < 3; i++)
                {
                    new Thread(instance.Method).Start();
                }

                Thread.Sleep(500);

                // Delay.
                Console.ReadKey();
            }
        }
    }
}