using System;

// Перевантаження оператора неявного перетворення типу.

// Ключове слово implicit служить створення оператора неявного перетворення типу.

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

        // Оператор неявного перетворення типу byte-to-Digit.
        public static implicit operator Digit(byte argument)
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

            // Неявне перетворення byte-to-Digit.
            Digit digit = variable;
            Console.WriteLine(digit);

            // Delay.
            Console.ReadKey();
        }
    }
}