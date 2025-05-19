using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Agent
    {
        // instance
        public string CodeName;
        private int ClearanceLevel;

        // constructor
        public Agent(string codeName, int clearanceLevel)
        {
            this.CodeName = codeName;
            //this.ClearanceLevel = clearanceLevel;
        }

        // get clearance level
        public void GetClearanceLevel()
        {
            Console.WriteLine($"Agent has clearance level: {this.ClearanceLevel}");
        }
        // set clearance level
        public void SetClearanceLevel(int clearanceLevel)
        {
            if (clearanceLevel > 0 && clearanceLevel < 6)
            {
                this.ClearanceLevel = clearanceLevel;
            }
            else
            {
                Console.WriteLine("Clearance level must be between 1 - 5");
            }
        }
        // method
        public void Report()
        {
            Console.WriteLine($"Agent {CodeName} reporting. Clearance Level: {ClearanceLevel}");
        }
    }
}
