using System;

namespace Static
{
    class NotStaticClass
    {
        // Якщо клас містить статичні поля, має бути наданий статичний конструктор,
        // який ініціалізує ці поля під час завантаження класу.

        private static int field;

        public static int Property
        {
            get { return field; }
            set { field = value; }
        }

        // Статичний архітектор.
        // Єдине призначення статичних конструкторів - надавати вихідні значення статичним змінним.
        static NotStaticClass()
        {
            Console.WriteLine("Статичний конструктор - NotStaticClass()");
            field = 1;
        }

        //Не статичний конструктор
        public NotStaticClass()
        {
            Console.WriteLine("Not static constructor!");
        }

        // Статичні методи можуть бути перевантажені.
        public static void Method()
        {
            Console.WriteLine("Статичний метод, неcтатичного NotStaticClass");
        }

        // Статичні методи можуть бути перевантажені.
        public static void Method(int s)
        {
            Console.WriteLine("Перевантажений статичний метод, нестатичний NotStaticClass " + s);
        }

        // Нестатичний метод.
        public void NotStaticMethod()
        {
            Console.WriteLine(field);
        }
    }
}
