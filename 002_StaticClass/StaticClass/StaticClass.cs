﻿using System;

// Статичний клас C#, висловлює ідею патерну проектування - Singleton.

// Правила:
// 1. Примірник статичного класу не можна створити.
// 2. Static class завжди успадковується від Оbject (Спроба успадкування чогось іншого призводить до помилці компіляції).
// 3. Static class не реалізує інтерфейси. Спроба наслідування від інтерфейсу призводить до помилки рівня компіляції.
// 4. Містить лише статичні члени (наявність у ньому нестатичного члена призведе до помилки компіляції).
// 5. Статичний клас неспроможна містити конструкторів екземплярів.
// 6. Статичний клас закритий для успадкування від цього. Спроба наслідування від статичного класу призводить до помилки рівня компіляції. 

namespace Static
{
    static class StaticClass //: object  // Спадкування тільки від Object (явно чи неявно)
    {
        // Контруктор екземпляра – неприпустимий.
        // public StaticClass()
        // {
        //    Console.WriteLine("Constructor.");
        // }

        // Статичний конструктор.
        static StaticClass()
        {
            Console.WriteLine("Static Constructor");
        }

        // Статичний метод.
        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
        }

        // Нестатичний метод - неприпустимий.
        // public void NotStaticMethod()
        // {
        //    Console.WriteLine("NotStaticMethod");
        // }
    }
}
