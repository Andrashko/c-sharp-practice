using System;

// Використовувати ключове слово operator можна тільки разом з ключовим словом static.

namespace Operators
{
    public struct Point
    {
        // Координати точки.

        private int x, y;

        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        // Перевантажений оператор ++.
        public static Point operator ++(Point p1)
        {
            return new Point(p1.x + 1, p1.y + 1);
        }

        // Перевантажений оператор --.
        public static Point operator --(Point p1)
        {
            return new Point(p1.x - 1, p1.y - 1);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        }
    }
}
