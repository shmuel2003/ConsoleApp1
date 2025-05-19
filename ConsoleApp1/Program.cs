using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agent agent1 = new Agent("asd", 2);
            Report report1 = new Report("anything", 4, agent1);
            MissionControl.AnalyzeReport(report1);
            IntelTools.LogTransmission("shmuel", "something");
        }
    }
}
