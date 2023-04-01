using System;
using System.Collections.Generic;

namespace Indexator1
{

    internal class Program
    {
        class IntList
        {
            private int[] elements;
            public int Count
            {
                get { return elements.Length; }
            }
            public IntList() { 
                elements = new int[0];
            }

            public int this[int index]
            {
                get
                { 
                    return elements[index];
                }
                set
                {
                    elements[index] = value;
                }
            }
        
            public int this[string index]
            {
            get
            {
                switch (index)
                {
                    case "One":
                        return elements[0];
                    case "Two":
                        return elements[1];
                    default: throw new IndexOutOfRangeException();
                }
            }
            
                set
                {
                    switch (index)
                    {
                        case "One":
                            elements[0] = value;
                            break;
                        case "Two":
                            elements[1] = value;
                            break;
                        default: throw new IndexOutOfRangeException();
                    }
             
                }
            }

            public void Add(int value)
            {
                Array.Resize(ref elements, Count+1);
                elements[Count-1]  = value;
            }

        }
        static void Main(string[] args)
        {/*
            List<int> elements = new List<int>();
            elements.Add(0);
            elements[0] = 42;
            elements.Add(1);
            elements.Add(2);
            */
            IntList elements = new IntList();
            elements.Add(0);
            elements["One"] = 42;
            elements.Add(1);
            elements.Add(2);
            Console.WriteLine(elements.Count);         
            Console.WriteLine(elements[0]);
                    
            Console.ReadLine();
        }
    }
}
