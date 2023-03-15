using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task2
{
    internal class Program
    {
        /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        Створіть чотири методи до виконання арифметичних операцій, з іменами: 
        Add – додавання, Sub – віднімання, Mul – множення, Div – поділ.
        Кожен метод повинен приймати два цілих аргументи і виводити на екран результат 
        виконання арифметичної операції відповідної імені методу. 
        Метод поділу Div повинен виконувати перевірку спроби поділу на нуль. 
        Потрібно надати користувачеві можливість вводити з клавіатури значення операндів 
        та знак арифметичної операції для виконання обчислень.*/ 
        private static readonly string[] signs = { "+", "-", "*", "/"};
        static void Main(string[] args)
        {
            Console.WriteLine("Type \"quit\" or \"exit\" to exit program");

            Console.WriteLine("");

            while (GetOperand("Input first number: ", out int operand1))
            {
                if (!GetOperand("Input second number: ", out int operand2) || !GetSign("Input Math operation sign ( + or - or / or * ): ", out string sign))
                {
                    break;
                }

                switch (sign)
                {
                    case "+":
                        Console.WriteLine(Add(operand1, operand2));
                        break;
                    case "-":
                        Console.WriteLine(Sub(operand1, operand2));
                        break;
                    case "*":
                        Console.WriteLine(Mul(operand1, operand2));
                        break;
                    case "/":
                        Console.WriteLine(Div(operand1, operand2));
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }


                Console.WriteLine("");
            }
        }

        private static string Add(int x, int y) 
        {
            return $"{x} + {y} = {x + y}";
        }

        private static string Sub(int x, int y)
        {
            return $"{x} - {y} = {x - y}";
        }

        private static string Mul(int x, int y)
        {
            return $"{x} * {y} = {x * y}";
        }

        private static string Div(int x, int y)
        {
            try
            {
                return $"{x} / {y} = {x / y}";
            }
            catch (DivideByZeroException e)
            {
                return "Operation canceled. " + e.Message;
            }
            
        }

        private static bool GetSign(string inputPrompt, out string sign)
        {
            do
            {
                Console.Write(inputPrompt);
                string userInput = Console.ReadLine().ToLowerInvariant();
                if (userInput == "quit" || userInput == "exit")
                {
                    sign = string.Empty;
                    return false;
                }
                if (signs.Contains(userInput))
                {
                    sign = userInput;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operator not recognized");
                    Console.ResetColor();
                }

            }
            while (true);
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
