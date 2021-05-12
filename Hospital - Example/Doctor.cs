using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBench
{
    class Doctor: Person
    {
        public Doctor(int id, string name, Insurance insurance) :base(id,name,insurance)
        {

        }

        public override void generateIdentityCard()
        {
            throw new NotImplementedException();
        }
    }
}
