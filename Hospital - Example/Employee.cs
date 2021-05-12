using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBench
{
    class Employee : Person
    {
        public Employee():base()
        {

        }
        public Employee(int id, string name, Insurance insurance) : base(id, name, insurance)
        {
        }

        public override void generateIdentityCard()
        {
            throw new NotImplementedException();
        }

        public new void displayInsuranceSummary()
        {

        }

        public virtual decimal calculateSalary()
        {
            return 25000;
        }
    }
}
