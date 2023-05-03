using System;

// Перевантаження оператора явного перетворення типу.

// Ключове слово explicit служить створення оператора явного перетворення типу.

namespace MyNamespace
{
    struct Digit
    {
        public byte value;

        // Конструктор.
        Digit(byte value)
        {
            this.value = value;
        }

        // Оператор явного перетворення типу byte-to-Digit.
        public static explicit operator Digit(byte argument)
        {
            Digit digit = new Digit(argument);
            return digit;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }

    class MainClass
    {
        static void Main()
        {
            byte variable = 1;

            // Явне перетворення byte-to-Digit.
            Digit digit = (Digit)variable; 

            Console.WriteLine(digit);

            // Delay.
            Console.ReadKey();
        }
    }
}