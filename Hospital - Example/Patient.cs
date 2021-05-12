using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBench
{
    class Patient: Person
    {
        public Patient(int id, string name, Insurance insurance, string patientCode) 
            : base(id, name, insurance)
        {
            PatientCode = patientCode;
        }

        public string PatientCode { get; set; }
        public List<Visit> Visits { get; set; }

        public override void generateIdentityCard()
        {
            throw new NotImplementedException();
        }

        public bool payPremium()
        {
            throw new NotImplementedException();
        }
    }
}
