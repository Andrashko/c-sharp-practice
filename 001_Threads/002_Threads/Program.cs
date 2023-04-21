using System;
using System.Threading;

// Потоки.

namespace Threads
{
    class Program
    {
        // Статичний метод, який планується виконувати одночасно у головному (первинному) та у вторинному потоках.
        static void WriteSecond()
        {
            // CLR призначає кожному потоку свій стек і методи мають власні локальні змінні.
            // Окремий екземпляр змінної counter створюється у стеку кожного потоку,
            // Тому кожного потоку виводяться, свої значення counter - 0, 1, 2.
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"Thread Id {Thread.CurrentThread.GetHashCode()}, counter = {counter}");
                counter++;
            }
        }

        static void Main()
        {
            // Робота вторинного потоку.
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            // Робота первинного потоку.
            WriteSecond();


            // Delay.
            Console.ReadKey();
        }
    }
}
