using System;

namespace Task2
{
    internal class Program
    {

        static int[] GenerateRandom (int n)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                result[i] = random.Next(1,100);
            }
            return result;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //найбільше значення
        static int MaxValue(int[] array)
        {
            int max = array[0];
            for(int i = 1; i<array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int[] MyReverse(int[] array)
        {
            int[] result = new int[array.Length];
            for(int i = 0; i<array.Length; i++)
            {
                result[array.Length-1-i] = array[i];
            }
            return result;
        }

        static void ArrayReverse(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[array.Length - 1 - i] = array[i];
            }
            //array = result;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = result[i];
            }
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] result = new int[count];

            
            return result;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int[] array = GenerateRandom(n);

                PrintArray(array);

                Console.WriteLine($"max {MaxValue(array)}");

                PrintArray(MyReverse(array));
                Array.Reverse(array);
                Console.WriteLine();
                PrintArray(array);
                ArrayReverse(array);
                Console.WriteLine();
                PrintArray(array);
            }
        }
    }
}
