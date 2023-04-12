using System;
using System.Linq;

namespace DelegateTask3
{
    /*
     * Створіть анонімний метод, який приймає в якості аргументу масив делегатів
     * і повертає середнє арифметичне значень, 
     * що повертаються методів, викладених з делегатами в масиві. 
     * Методи, повідомлені з делегатами з масиву,
     * повертають випадкове значення типу int.
     */
    internal class Program
    {
        public delegate int DelegateRandomInt();
        public delegate double DelegateAvg(DelegateRandomInt[] arr);

        public static int GenRandomInt()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }

        public static int OtherRandomInt()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }
        static void Main(string[] args)
        {
            DelegateAvg AnonimusMethod = (DelegateRandomInt[] arr) =>
            {
                double s = 0;
                for(int i=0; i<arr.Length; i++)
                    s += arr[i] ();
                return s / arr.Length;
            };

            DelegateRandomInt[] arr = new DelegateRandomInt[] 
            { GenRandomInt, ()=>42, GenRandomInt, OtherRandomInt};
            Console.WriteLine(AnonimusMethod(arr));

            Comparison<DelegateRandomInt> comp = (DelegateRandomInt d1, DelegateRandomInt d2) => 0;
            Comparison<String> st;
            Array.Sort(arr, comp );

            Console.ReadLine();
        }
    }
}
