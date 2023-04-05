using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Book
{
    class Book
    {
        public class Notes
        {
            public string[] Lines;

            public Notes(int count)
            {
                Lines = new string[count];
                for (int line = 0; line < Lines.Length; line++)
                {
                    Lines[line] = "";
                }
            }

            public void Add(string note)
            {
                for (int line = 0; line < Lines.Length; line++)
                {
                    if (Lines[line] == "")
                    {
                        Lines[line] = note;
                        break;
                    }
                }
            }
            public void Print()
            {
                for (int line = 0; line < Lines.Length; line++)
                {
                    Console.WriteLine(Lines[line]);
                }
            }
        }
        public string[][] Pages { get; set; }
        public Notes notes { get; set; }

        public Book(string[][] pages, int notesCount = 10)
        {
            Pages = pages;
            notes = new Notes(notesCount);
        }
        /*
        public void FindNext(string str)
        {
            for(int page=0; page<Pages.Length; page++)
            {
                for(int row=0; row < Pages[page].Length; row++)
                {
                    if (str == Pages[page][row])
                    {
                        Console.WriteLine($"Рядок {str} знайдено на сторінці {page}");
                        return;
                    }
                }
            }
            Console.WriteLine($"В книзі не знайдено рядок {str}");

        }*/
    }

}
