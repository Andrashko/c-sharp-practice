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

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }

        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.x * p2.x, p1.y * p2.y);
        }

        public static Point operator /(Point p1, Point p2)
        {
            return new Point(p1.x / p2.x, p1.y / p2.y);
        }
        
        // Методи.
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        }

        // Operator + через Add().
        public static Point Add(Point p1, Point p2)
        {
            return p1 + p2;
        }

        // Operator - через Subtract().
        public static Point Subtract(Point p1, Point p2)
        {
            return p1 - p2;
        }
    }
}
