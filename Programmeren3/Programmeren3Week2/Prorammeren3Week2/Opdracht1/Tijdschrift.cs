using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Tijdschrift : Product
    {
        private string release;
        public string Release
        {
            get { return release; }
            set { release = value; }
        }
        public Tijdschrift(string titel, string release, double prijs, int count) : base(titel, prijs, count)
        {
            this.Release = release;
        }

        override public void Print()
        {
            Console.WriteLine(String.Format("[Magazine] {0} released on {1} for {2}", Titel, Release, TotaalPrijs));

        }
    }
}
