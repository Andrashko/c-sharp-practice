using System;

// Використовувати ключове слово operator можна тільки разом з ключовим словом static.

namespace Operators
{
    public struct Point : IComparable
    {
        // Координати точки.
        private int x, y;

        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        public static bool operator <(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) < 0);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) > 0);
        }

        public static bool operator <=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) <= 0);
        }

        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) >= 0);
        }


        // Реалізація інтерфейсу IComparable.

        public int CompareTo(object obj)
        {
            if (obj is Point)
            {
                Point p = (Point)obj;

                if (this.x > p.x && this.y > p.y)
                {
                    return 1;
                }
                else if (this.x < p.x && this.y < p.y)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
