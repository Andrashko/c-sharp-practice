using System;

namespace DateOperator
{
    /*
     * Створіть клас, який буде містити інформацію про дату 
     * (день, місяць, рік).
     * За допомогою механізму перевантаження 
     * операторів, визначте операцію різниці двох дат 
     * (результат у вигляді кількості днів між датами), 
     * а також операцію збільшення дати на певну кількість днів.
     */
    class MyDate
    {
        private int _day;
        public  int Day { get { return _day; } set
            {
                if ( value <= 0 || value > 31)
                {
                    throw new Exception("Wrong day");
                }
                _day = value;
            }
        }

        public int Month { get; set; }
        public int Year { get; set; }

        public MyDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
