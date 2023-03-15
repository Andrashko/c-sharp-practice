using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Task4
{
    internal class Program
    {
        /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
          Напишіть метод, який визначатиме: 
        1) чи є введене число позитивним чи негативним. 
        2) Чи є воно простим(використовуйте техніку перебору значень). 
        (Просте число - це натуральне число, яке ділиться на 1 і саме на себе.
        Щоб визначити просте число чи ні, слід знайти всі цілі дільники.
        Якщо дільників більше 2-х, значить воно не просте.) 
        3) Чи ділиться на 2 , 5, 3, 6, 9 без залишку.*/
        static void Main(string[] args)
        {
            while (GetOperand("Input integer number: ", out int operand))
            {
                
                if (IsPositive(operand))
                {
                    Console.WriteLine($"{operand} is a positive number");
                }
                else
                {
                    Console.WriteLine($"{operand} is a negative number");
                }

                if (IsPrimeNumber(operand))
                {
                    Console.WriteLine($"{operand} is a Prime number");
                }
                else
                {
                    Console.WriteLine($"{operand} is not a Prime number");
                }

                int[] ints = new[] { 2, 5, 3, 6, 9 };

                StringBuilder sb = new StringBuilder($"{operand} is divided by");
                foreach (int number in ints)
                {
                    sb.Append(" ");
                    sb.Append(number.ToString());
                    sb.Append(",");
                }
                sb.Remove(sb.Length - 1, 1);

                if (IsDevidedWithoutReminder(operand, ints))
                {
                    sb.Append(" without a riminder");
                }
                else
                {
                    sb.Append(" with a riminder");
                }

                Console.WriteLine(sb.ToString());

                Console.WriteLine("");
            }
        }

        private static bool IsPositive(int number)
        {
            if (number < 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsDevidedWithoutReminder(int number, int[] dividers)
        {
            foreach (int divider in dividers)
            {
                if (number % divider != 0)
                {
                    return false;
                }
            }

            return true;
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
