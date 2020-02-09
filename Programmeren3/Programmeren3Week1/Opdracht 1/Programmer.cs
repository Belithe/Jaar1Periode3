using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    class Programmer
    {
        public string name;
        public Specialty specialty;

        public Programmer(string inputName, Specialty inputSpecialty)
        {
            name = inputName;
            specialty = inputSpecialty;
        }

        public Programmer(string inputName) : this(inputName, Specialty.Unknown)
        {

        }
        public void Print()
        {
            Console.WriteLine(String.Format("Name: {0} Specialty: {1}", this.name, specialty.ToString()));
        }
    }
}
