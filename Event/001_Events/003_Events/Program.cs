using System;
using System.Text;

// Події.

namespace Events
{
    public delegate void PressKeyEventHandler();

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;
        //  C ... Z

        public void PressKeyAEvent()
        { 
            PressKeyA?.Invoke(); // викликаємо метод Invoke на подію       
        }

        public void PressKeyBEvent()
        {
            if (PressKeyB != null)
            {
                PressKeyB.Invoke();
            }
        }

        public void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();

                switch (s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent();
                        break;
                    case "b":
                    case "B":
                        PressKeyBEvent();
                        break;
                    case "exit":
                        goto Exit;

                    default:
                        Console.WriteLine("Немає обробника натискання клавіші {0}", s);
                        break;
                }
            }
        Exit:
            Console.WriteLine("Exit!");
        }
    }

    class Program
    {
        // Методи обробники події.

        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("    X    ");
            Console.WriteLine("   X X   ");
            Console.WriteLine("  X   X  ");
            Console.WriteLine(" XXXXXXX ");
            Console.WriteLine("X       X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyB_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("XXXXX  ");
            Console.WriteLine("X    X ");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine("X     X");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Keyboard keyboard = new Keyboard();

            // Передплата на подію.
            keyboard.PressKeyA += new PressKeyEventHandler(PressKeyA_Handler);
            keyboard.PressKeyB += PressKeyB_Handler;

            // Запуск методу, який стежитиме за натисканням клавіш 
            keyboard.Start();
        }
    }
}
