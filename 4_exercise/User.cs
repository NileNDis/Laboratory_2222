using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_exercise
{
    class User
    {
        private string login = "QWERTY";
        private string name = "Denches";
        private string surname = "Danilenko";
        private int age = 18;
        private const string date = "11.02.2022";

        public void Vivod()
        {
            Console.WriteLine($"Login: {login};\nName: {name};\nSurname: {surname};\nAge: {age};\nDate: {date};");
        }
    }
}
