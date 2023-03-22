using System;
using System.Linq;

namespace People
{
    class Person
    {
        private string _name;
        private int[] _marks;
        private int _age;
        public int age
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Negative age is incorect");
                    _age = 0;
                    return;
                }
                _age = value;
            }
            get
            {
                return _age;
            }
        }

        public bool isFoolYear
        {
            get
            {
                if (_age >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void SayHi()
        {
            Console.WriteLine($"Hi, {_name}");
        }
        public Person(string name, int marksCount = 3)
        {
            _name = name;
            _marks = new int[marksCount];
        }

        public Person(string name, int[] marks)
        {
            _name = name;
            _marks = marks;
        }

        //ввід оцінок

        public void EnterMarks()
        {
            Console.WriteLine($"Please enter {_marks.Length} marks");
            for(int i=0; i< _marks.Length; i++)
            {
                _marks[i] = int.Parse(Console.ReadLine());
            }
        }

        //вивід оцінок
        public void WriteMarks()
        {

            Console.Write($"{_name} marks are: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < _marks.Length; i++)
            {
                Console.Write(_marks[i].ToString() + " ");
            }
            Console.WriteLine();
        }

        //середня оцінка
        public double CalcullateAvgMark()
        {
            double sum = 0;
            foreach (int mark in _marks)
            {
                sum += mark;
            }
            return sum / _marks.Length;
        }

        public double AvgMark
        {
            get { 
                return CalcullateAvgMark(); 
            }
        }

        //викинути 2
        public int[] FilterTwos()
        {
            return _marks.Where(mark => mark > 2).ToArray();
           
        }

    }

}