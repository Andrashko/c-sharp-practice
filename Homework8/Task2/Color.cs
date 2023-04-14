using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    static class ColorfulLife
    {
        public enum UsersColor
        {
            Blue,
            White,
            Black,
            Red,
            Green,
            Yellow,
            Cyan
        }

        public static void Print(string text, UsersColor color)
        {
            Console.ForegroundColor = GetConsoleColor(color);
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private static ConsoleColor GetConsoleColor(UsersColor color)
        {
            switch (color)
            {
                case UsersColor.Blue:
                    return ConsoleColor.Blue;
                case UsersColor.White:
                    return ConsoleColor.White;
                case UsersColor.Black:
                    return ConsoleColor.Black;
                case UsersColor.Red:
                    return ConsoleColor.Red;
                case UsersColor.Green:
                    return ConsoleColor.Green;
                case UsersColor.Yellow:
                    return ConsoleColor.Yellow;
                case UsersColor.Cyan:
                    return ConsoleColor.Cyan;
                default:
                    return ConsoleColor.Gray;
            }
        }
    }
}
