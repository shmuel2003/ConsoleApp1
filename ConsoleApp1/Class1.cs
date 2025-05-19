using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        // instance
        public int Age;
        public string Name;
        private int password;

        //constructor
        public Class1(int age, string name)
        {
            this.Age = age;
            this.Name = name;
            this.password = 0;
        }
        // method
        public void Print()
        {
            Console.WriteLine("Name: " + this.Name + ", Age: " + this.Age);
        }
        // set password
        public void SetPassword()
        {
            if (password > 0)
            {
                this.password = 647483;
            }
            else
            {
                Console.WriteLine("Password must be a positive number");
            }
        }
        // get password
        public void getPassword()
        {
            Console.WriteLine("Password: " + this.password);
        }
    }
}
