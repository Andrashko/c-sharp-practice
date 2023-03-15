using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task3
{
    internal class Program
    {
        /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        Напишіть програму, яка буде конвертувати валюти. 
        Користувач вводить: суму грошей у певній валюті.курс конвертації в іншу валюту.
        Організуйте виведення результату операції конвертування валюти на екран.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Type \"quit\" or \"exit\" to exit program");

            Console.WriteLine("");

            while (GetOperand("Input ammount of a currency: ", out decimal operand1))
            {
                if (!GetOperand("Input currency exchange rate: ", out decimal operand2))
                {
                    break;
                }

                Console.WriteLine($"Ammount of a currency that is bought: {operand1 * operand2}");
                Console.WriteLine("");
            }
        }

        private static bool GetOperand(string inputPrompt, out decimal operand)
        {
            do
            {
                Console.Write(inputPrompt);
                string userInput = Console.ReadLine().ToLowerInvariant();
                if (userInput == "quit" || userInput == "exit")
                {
                    operand = 0;
                    return false;
                }

                if (decimal.TryParse(userInput.Replace(",", "."), out decimal result))
                {
                    operand = result;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Data not recognized as a number");
                    Console.ResetColor();
                }
            }
            while (true);
        }
    }
}
