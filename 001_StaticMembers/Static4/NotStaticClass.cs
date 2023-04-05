using System;

// Статичні поля та властивості.

namespace Static
{
    class NotStaticClass
    {
        // Статичне поле.
        static int field;

        // Статична властивість.
        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
    }
}