using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class User
    {
        private string login;
        private string name;
        private string lastName;
        private int age;
        private DateTime dateOfregister;

        public string Login
        {
            set => login = value;
            get => login;
        }
        public string Name
        {
            set => name = value;
            get => name;
        }
        public string LastName
        {
            set => lastName = value;
            get => lastName;
        }
        public int Age
        {
            set => age = value;
            get => age;
        }
        public DateTime DateOfregister
        {
            get => dateOfregister;
        }

        public User(string login, string name, string lastName, int age, DateTime dateOfregister)
        {
            Login = login;
            Name = name;
            LastName = lastName;
            Age = age;
            this.dateOfregister = dateOfregister;
        }
    }
}
