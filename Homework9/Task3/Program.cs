using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
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
            DelegateAvg AnonimusMethod = (DelegateRandomInt[] myArr) =>
            {
                double s = 0;
                for (int i = 0; i < myArr.Length; i++)
                    s += myArr[i]();
                return s / myArr.Length;
            };

            DelegateRandomInt[] arr = new DelegateRandomInt[]
            {GenRandomInt, GenRandomInt, OtherRandomInt};
            Console.WriteLine(AnonimusMethod(arr));

            Console.ReadLine();
        }
    }
}
