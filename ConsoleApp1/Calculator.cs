using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        // instance
        public int num1;
        public int num2;

        // constructor
        public Calculator(int number1, int number2)
        {
            this.num1 = number1;
            this.num2 = number2;
        }

        // method
        public void Add()
        {
            Console.WriteLine($"sum is: {this.num1 + this.num2}");
        }
        public void Subtract()
        {
            Console.WriteLine($"subtraction is: {this.num1 - this.num2}");
        }
        public void Multiply()
        {
            Console.WriteLine($"multiplication is: {this.num1 * this.num2}");
        }
        public void Divide()
        {
            if (this.num2 != 0)
            {
                Console.WriteLine($"division is: {Convert.ToDouble(this.num1) / Convert.ToDouble(this.num2)}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}
