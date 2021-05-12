using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBench
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Insurance Insurance { get; set; }

        public Person() { }
        public Person(int id, string name, Insurance insurance)
        {
            Id = id;
            Name = name;
            Insurance = insurance;
        }

        public abstract void generateIdentityCard();
        
        public void displayInsuranceSummary()
        {
            Console.WriteLine("-----------Summary---------");
            Console.WriteLine(Insurance.Id);
            Console.WriteLine(Insurance.Name);
            Console.WriteLine("---------------------------");
        }
    }
}
