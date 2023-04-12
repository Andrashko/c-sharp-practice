using System;

namespace ExampleDelegate
{
    internal class Program
    {
        public delegate string[] LoadDelegate(string url);

        public static string[] LoadFromTelegram(string url)
        {
            return new string[] { "one", "two" };
        }

        public static string[] LoadFromViber(string url)
        {
            return new string[] { "1", "2","3"};
        }

        public static string FirstMessage(LoadDelegate loader)
        {
            string[] messages = loader("");
            return messages[0];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(
                FirstMessage(
                    LoadFromTelegram
                    )
                );
            Console.WriteLine(FirstMessage(LoadFromViber));
            string message = FirstMessage(url => new string[] { "-----", "****" });
            Console.WriteLine(message);
            Predicate<int> isEven =  x => x % 2 == 0; 
            Console.ReadLine();
        }

        private static bool isEven2(int x)
        {
            return x % 2 == 0;
        }
    }
}
