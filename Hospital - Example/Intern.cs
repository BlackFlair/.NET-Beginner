using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBench
{
    class Intern : Employee
    {
        public int NoOfHours { get; set; }

        public Intern(): base()
        {

        }

        public Intern(int id, string name, Insurance insurance) : base(id, name, insurance)
        {
        }

        public override decimal calculateSalary()
        {
            return 10000;
        }
    }
}
