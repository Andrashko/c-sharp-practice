using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _005_Book;

namespace Managers
{
    class FindAndReplaceManager
    {
        public static void FindNext(string str, Book book)
        {
            for (int page = 0; page < book.Pages.Length; page++)
            {
                for (int row = 0; row < book.Pages[page].Length; row++)
                {
                    if (str == book.Pages[page][row])
                    {
                        Console.WriteLine($"Рядок {str} знайдено на сторінці {page}");
                        return;
                    }
                }
            }
            Console.WriteLine($"В книзі не знайдено рядок {str}");
        }
    }
}
