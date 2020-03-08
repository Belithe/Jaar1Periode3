using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Tijdschrift : Product
    {
        public string release;
        public Tijdschrift(string release, string titel, double prijs) : base(titel, prijs)
        {
            this.release = release;
        }

        override public void Print()
        {
            Console.WriteLine(String.Format("[Magazine] '{0}' released on {1} for {2}", titel, release, prijs));

        }
    }
}
