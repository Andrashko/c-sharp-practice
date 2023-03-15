using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            monthPay(100);
        }
        static void monthPay(int sumPayment)
        {
            Console.WriteLine("Введiть суму платежу: ");
            int sumPay = int.Parse(Console.ReadLine());
            int totalSumDebt = 700;
            int maxCountPay = 7;

            if (sumPay == 0)
            {
                return;
            }

            totalSumDebt -= sumPay;
            maxCountPay--;

            if (totalSumDebt == 0)
            {
                maxCountPay = 0;
                Console.WriteLine("Сума погашена");
                return;
            }

            else if (totalSumDebt > 0)
            {
                Console.WriteLine($"Сума довгу {totalSumDebt}, залишилось {maxCountPay} платежiв");
            }

            Console.ReadKey();

        }
    }
}
