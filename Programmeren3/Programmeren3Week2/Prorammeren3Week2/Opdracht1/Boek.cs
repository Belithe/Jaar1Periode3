using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Boek : Product
    {
        public string auteur;

        public Boek(string auteur, string titel, double prijs) : base(titel, prijs)
        {
            this.auteur = auteur;
        }

        override public void Print()
        {
            Console.WriteLine(String.Format("[Book] '{0}' by {1} for {2}", titel, auteur, prijs));
        }


    }
}
