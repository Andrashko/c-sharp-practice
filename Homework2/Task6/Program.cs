using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User ("Gressot", "Oleksandr", "Lutso", 35);
            User otherUser = new User("Test", "Yurii", "Andrashko", 33);
            Console.WriteLine("\nДанi про користувача");
            Console.WriteLine("\nЛогiн: " + user.Login);
            Console.WriteLine("Iм'я: " + user.Name);
            Console.WriteLine("Прiзвище: " + user.LastName);
            Console.WriteLine("Вiк: " + user.Age);
            Console.WriteLine("Дата заповнення: " + user.DateOfregister);

            user.Login = "NewLogin";


            Console.WriteLine("\nДанi про користувача");
            Console.WriteLine("\nЛогiн: " + user.Login);
            Console.WriteLine("Iм'я: " + user.Name);
            Console.WriteLine("Прiзвище: " + user.LastName);
            Console.WriteLine("Вiк: " + user.Age);
            Console.WriteLine("Дата заповнення: " + user.DateOfregister);

            Console.ReadKey();
        }
    }
}
