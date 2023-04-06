using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System;

// Розширюючі методи. (Extension methods)

// Розширювальні методи можуть бути лише статичними та створюватися лише у статичних класах.

namespace Extension
{
    static class ExtensionClass
    {
        // this - повідомляє компілятор, що даний метод є розширюючим(Extension)!
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
    }

    class Program
    {
        static void Main()
        {
            string text = "Тестовая строка";

            // Виклик методу, як статичного.
            ExtensionClass.ExtensionMethod(text);

            // Виклик методу, як розширюючого.
            text.ExtensionMethod();


            // Delay.
            Console.ReadKey();
        }
    }
}

