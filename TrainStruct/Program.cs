using System;

namespace DateOperator
{
    class Person
    {
        public string Name { get; set; }
        public MyDate Birthday { get; set; }
    }
    /*
     * Створіть клас, який буде містити інформацію про дату 
     * (день, місяць, рік).
     * За допомогою механізму перевантаження 
     * операторів, визначте операцію різниці двох дат 
     * (результат у вигляді кількості днів між датами), 
     * а також операцію збільшення дати на певну кількість днів.
     */

    public class MyDate
    {
        private int _day;
        public int Day
        {
            get { return _day; }
            set
            {
                if (value <= 0 || value > 31)
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

        public static int operator - (MyDate fromDate, MyDate toDate)
        {
            return fromDate.ToDays() - toDate.ToDays();
        } 

        private int ToDays()
        {
            int result = Day;
            result += Month * 30; //
            result += Year * 365; //
            return result;
        }

        private MyDate Clone()
        {
            return new MyDate(Year, Month, Day);
        }

        public static MyDate operator + (MyDate date, int  days)
        {
            /*MyDate result = date.MemberwiseClone() as MyDate;
            //var result = date.Clone();
            result.Day += days;
            return result;*/

            int day = date.Day + days;
            int month = date.Month;
            int year = date.Year;
            if (day > 30) //
            {
                month += 1;
                day -= 30;
            }
            if (month > 12) //
            {
                year += 1;
                month -= 12;
            }
            return new MyDate(year, month, day);    
        }
        public override string ToString()
        {
            return $"{Day}.{Month}.{Year}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDate date = new MyDate(2023, 12, 29);
            MyDate startDate = new MyDate(2023, 2, 24);
            Console.WriteLine(date - startDate);
            Console.WriteLine(date + 30);
            Console.WriteLine(date);    

            Console.ReadLine();
        }
    }
}
