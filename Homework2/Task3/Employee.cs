using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string position;
        private double workedDayOfMonth;
        private int dayOfMonth;
        private double salary;


        public string FirstName
        {
            set => FirstName = value;
            get => firstName;
        }
        public string LastName
        {
            set => LastName = value;
            get => lastName;
        }
        public double Salary
        {
            set => Salary = value;
            get => salary;
        }

        public string Position
        {
            get => this.position;
        }

        public Employee(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public void SetPosition(string Position)
        {
            this.position = Position;
        }

        public void WorkedDay(int WorkedDayOfMonth)
        {
            this.workedDayOfMonth = WorkedDayOfMonth;
        }


        public double TaxCalculate(double salary)

        {
            return salary * 0.2;
        }

        public void CalculateSalary()
        {
            
            switch (position)
            {
                case "Manager":
                    salary = (double)salary / dayOfMonth * workedDayOfMonth;
                    break;

                case "Accountant":
                    salary = (double)salary / dayOfMonth * workedDayOfMonth;
                    break;

                case "Secretary":
                    salary = (double)salary / dayOfMonth * workedDayOfMonth;
                    break;
                default:
                    Console.WriteLine("Вибачте, але такої посади не має :(");
                    break;
            }
            
        }
               
    }
}
