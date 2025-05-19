using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MissionControl
    {
        // method
        public static void AnalyzeReport(Report r)
        {
            if (r.urgencyLevel >= 4)
            {
                Console.WriteLine("Immediate response required.");
            }
            else if (r.urgencyLevel == 3)
            {
                Console.WriteLine("High priority. Monitor closely.");
            }
            else
            {
                Console.WriteLine("Routine analysis.");
            }
        }
    }
}
