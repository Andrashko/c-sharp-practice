using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task6
{
    internal class Program
    {
        /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        Створіть метод з ім'ям Calculate, який приймає як параметри три цілих аргументи 
        і виводить на екран середнє арифметичне значень аргументів.*/
        static void Main(string[] args)
        {

            Console.WriteLine("Type \"quit\" or \"exit\" to exit program");

            Console.WriteLine("");

            while (GetOperand("Input first number: ", out int operand1))
            {
                if (!GetOperand("Input second number: ", out int operand2))
                {
                    break;
                }

                if (!GetOperand("Input third number: ", out int operand3))
                {
                    break;
                }

                Calculate(operand1, operand2, operand3);


                Console.WriteLine("");
            }
        }

        private static void Calculate(int x, int y, int z)
        {
            Console.WriteLine($"Arithmetic average of {x}, {y} and {z} is {(x + y + z) / 3}");
        }

        private static bool GetOperand(string inputPrompt, out int operand)
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

                if (int.TryParse(userInput.Replace(",", "").Replace(".", ""), out int result))
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
