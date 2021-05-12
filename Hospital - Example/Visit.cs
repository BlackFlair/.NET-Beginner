using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBench
{
    class Visit
    {
        public int Id { get; set; }
        public DateTime VisitDate { get; set; }
        public string IssueDetail { get; set; }
        public Patient Patient { get; set; }
    }
}
