using System;
using System.Text;
using System.Threading;

// Потоки.

namespace Threads
{
    class Program
    {
        static void WriteSecond()
        {
            // Thread.CurrentThread - повертає посилання на екземпляр поточного потоку.
            Thread thread = Thread.CurrentThread;

            // Привласнюємо потоку ім'я.
            thread.Name = "Secondary";

            // Виводимо на екран інформацію про поточний потік.
            Console.WriteLine($"ID потоку {thread.Name}: {thread.GetHashCode()}");

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(new string(' ', 15) + thread.Name + " " + counter);
                // Зупиняємо виконання поточного потоку.
                Thread.Sleep(1000);
            }           
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Отримуємо посилання на екземпляр поточного потоку.
            Thread primaryThread = Thread.CurrentThread;

            // Привласнюємо потоку ім'я.
            primaryThread.Name = "Primary";

            // Виводимо на екран інформацію про поточний потік.
            Console.WriteLine($"ID потоку {primaryThread.Name}: {primaryThread.GetHashCode()}");


            // Робота вторинного потоку.
            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();

            // Робота первинного потоку.
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(primaryThread.Name + " " + counter);
                // Зупиняємо виконання поточного потоку.
                Thread.Sleep(1500);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
