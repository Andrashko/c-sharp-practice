using System;
using System.Threading;

// Основні та фонові потоки. За промовчанням властивість IsBackground дорівнює false.

namespace Threads
{
    class Program
    {
        // Метод, який планується виконувати у окремому потоці.
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 15) + "Secondary");
                Thread.Sleep(500);
            }
        }

        static void Main()
        {
            // Робота вторинного потоку.
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            // Робота первинного потоку.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Primary");
                Thread.Sleep(500);
            }

            // Завершити роботу вторинного потоку
            //thread.IsBackground = true;
        }
    }
}
