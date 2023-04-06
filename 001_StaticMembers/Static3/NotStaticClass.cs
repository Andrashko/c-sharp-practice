﻿using System;

// Константы.

namespace Static
{
    class NotStaticClass
    {
        // Константи не можуть бути статичними.
        // public static const float e = 2.71828182845904523536f;

        // Поле, що не може бути оголошено як static const, поле const за своєю поведінкою вже є статичним.
        // Поле const відноситься до типу, а не до екземплярів типу.
        // Тому до полів const можна звертатися з використанням тієї ж нотації Ім'яКласу.
        // що й у використовуваної для статичних полів.

        public const float e = 2.71828182845904523536f;
    }
}
