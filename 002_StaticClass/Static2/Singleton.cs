using System;

namespace Static
{
    // "Singleton"
    class Singleton
    {
        private static Singleton instance = null;

        // Конструктор - "protected" 
        protected Singleton() 
        {
        }

        // Фабричний метод.
        public static Singleton Instance()
        {
            // Якщо: об'єкт ще не створено  (1)         
            if (instance == null)
            {
                // То: створюємо новий екземпляр  (2)
                instance = new Singleton();
            }
            // Інакше: повертаємо посилання на існуючий об'єкт  (3)
            return instance;
        }
    }
}
