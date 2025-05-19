using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mission
    {
        // instance
        public string MissionName;
        public string TargetLocation;
        public Agent AssignedAgent;

        // constructor
        public Mission(string missionName, string targetLocation)
        {
            this.MissionName = missionName;
            this.TargetLocation = targetLocation;
        }
        // method to assign agent
        public void AssignAgent(Agent agent)
        {
            this.AssignedAgent = agent;
        }

        // method
        public void Brief()
        {
            Console.WriteLine($"Mission: {MissionName}, Target: {TargetLocation}, Agent: {this.AssignedAgent.CodeName}");
        }
    }
}
