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
        private int dayOfMonth = 30;
        private double salary;


        public string FirstName
        {
            set => firstName = value;
            get => firstName;
        }
        public string LastName
        {
            set => LastName = value;
            get => lastName;
        }
        public double Salary
        {
            get => salary;
        }

        public string Position
        {
            get => this.position;
            set  
            {
                switch (value)
                {
                    case "Manager":
                        salary = 20000;
                        break;
                    case "Accountant":
                        salary = 30000;
                        break;

                    case "Secretary":
                        salary = 15000;
                        break;
                    default:
                        throw new Exception("Вибачте, але такої посади не має :(");
                }
                this.position = value;
            }
        }

        public Employee(string FirstName, string LastName, string Position)
        {
            firstName = FirstName;
            lastName = LastName;
            this.Position = Position;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public void WorkedDay(int WorkedDayOfMonth)
        {
            this.workedDayOfMonth = WorkedDayOfMonth;
        }

        // не взаємодіє з   public double Salary
        public double TaxCalculate()

        {
            return salary * 0.2;
        }

        public double CalculateSalary()
        {
            
            return Salary / dayOfMonth * workedDayOfMonth;
            
        }
               
    }
}
