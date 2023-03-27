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
            Employee employee = new Employee("Oleksandr", "Lutso");

            employee.SetPosition("Manager");
            employee.WorkedDay(25);
            employee.CalculateSalary();
            employee.TaxCalculate(50000);
            //помилка виклику методу 
            Console.WriteLine($"\nІм'я: {employee.FirstName}\nПрізвище: {employee.LastName}\nПосада: \nОклад: \nПодатковий збір: {employee.TaxCalculate}");

            Console.ReadKey();
        }
    }
}
