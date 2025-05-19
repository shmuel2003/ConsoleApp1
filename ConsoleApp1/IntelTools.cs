using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class IntelTools
    {
        public static string EncryptMessage(string msg)
        {
            char[] charArray = msg.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static void LogTransmission(string agentName, string message)
        {
            Console.WriteLine($"{agentName} sent encrypted message: {message}");
        }
    }
}
