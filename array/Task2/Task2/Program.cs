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
        /*2) Створіть метод int [] SubArray (int [] array, int index, int count).
         * Метод повертає частину отриманого як аргумент масиву, починаючи 
         * з позиції зазначеної в аргументі index, розмірністю, яка відповідає 
         * значенню аргументу count. Якщо аргумент count містить значення більше, 
         * ніж кількість елементів, які входять до частини вихідного масиву 
         * (від зазначеного індексу index, до індексу останнього елемента), 
         * то при формуванні нового масиву розмірністю в count, заповніть одиницями 
         * ті елементи, які не були скопійовані з вихідного масиву
         * */
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] result = new int[count];

            int j = 0;
            for(int i = index; (j<count) && (i<array.Length); i++)
            {
                result[j] = array[i];
                j++;
            }
            
            for(j=j; j < count; j++)
            {
                result[j] = 1;
            }

            return result;
        }

        static void IncSize(ref int[] array)
        {
            Array.Resize(ref array, array.Length+1);  
        }

        /*
         * Створіть метод, який приймає два аргументи, 
         * перший аргумент типу int [ ] array, 
         * другий аргумент типу int value. 
         * У тілі методу реалізуйте можливість додавання другого 
         * аргументу методу до масиву за індексом – 0, 
         * при цьому довжина нового масиву повинна збільшитися
         * на 1 елемент, а елементи одержуваного масиву як перший аргумент 
         * мають скопіюватися в новий масив починаючи з індексу - 1. 
         */
        static void ShiftArray(ref int[] array, int value)
        {
            IncSize(ref array);

            for(int i = array.Length-1; i>0; i--)
            {
                array[i] = array[i-1];
            }

            array[0] = value;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int[] array = GenerateRandom(n);
                Console.WriteLine("array");
                PrintArray(array);
                ShiftArray(ref array, 100);
                Console.WriteLine("array with 100");
                PrintArray(array);

                /*
                int[] copy = SubArray(array, 2, 3);
                Console.WriteLine("array");
                PrintArray(array);
                Console.WriteLine("copy");
                PrintArray(copy);
                /*

                /*
                PrintArray(array);

                Console.WriteLine($"max {MaxValue(array)}");

                PrintArray(MyReverse(array));
                Array.Reverse(array);
                Console.WriteLine();
                PrintArray(array);
                ArrayReverse(array);
                Console.WriteLine();
                PrintArray(array);
                */
            }
}
    }
}
