using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Personal:Car
    {
        public override void start()
        {
            Console.WriteLine("start");
        }
        public override void stop()
        {
            Console.WriteLine("stop");
        }
    }
}
