using System;
using People;

namespace Classs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person yurii = new Person("Yurii");
            Person natali = new Person("Natali");
            yurii.SayHi();
            natali.SayHi();

            yurii.age = -33; 
            Console.WriteLine($"Age is {yurii.age}");
            if (yurii.isFoolYear)
            {
                Console.WriteLine("Access alowed");
            }

            yurii.EnterMarks();
            yurii.WriteMarks();

            Console.WriteLine($"avg = {yurii.AvgMark}");

            foreach (int mark in yurii.FilterTwos())
            {
                Console.WriteLine(mark);
            }
            Console.ReadLine();
        }
    }
}
