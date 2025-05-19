using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Report
    {
        // instance
        public string summary;
        public int urgencyLevel;
        Agent submittedBy;

        // constructor
        public Report(string summary, int urgencyLevel, Agent submittedBy)
        {
            this.summary = summary;
            this.urgencyLevel = urgencyLevel;
            this.submittedBy = submittedBy;
        }

    }
}
