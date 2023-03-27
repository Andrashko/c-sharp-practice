using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Oleksandr", "Lutso", "Manager");
            employee.FirstName = "Alex";
            employee.SetPosition("Accountant");
            employee.WorkedDay(25);
            double salary = employee.CalculateSalary();
            employee.TaxCalculate();
            //помилка виклику методу 
            Console.WriteLine($"\nІм'я: {employee.FirstName}\nПрізвище: {employee.LastName}\nПосада:{employee.Position} \nОклад:{employee.Salary} \nПодатковий збір: {employee.TaxCalculate()} \nВиплата {salary}");
            employee.Position = "Secretary";
            Console.WriteLine($"\nІм'я: {employee.FirstName}\nПрізвище: {employee.LastName}\nПосада:{employee.Position} \nОклад:{employee.Salary} \nПодатковий збір: {employee.TaxCalculate()} \nВиплата {employee.CalculateSalary()}");
            employee.Position = "Teacher";
            Console.ReadKey();
        }
    }
}
