using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Boek : Product
    {
        public string Auteur { get; private set; }

        public Boek(string auteur, string titel, double prijs, int count) : base(titel, prijs, count)
        {
            this.Auteur = auteur;
        }

        override public void Print()
        {
            Console.WriteLine(String.Format("[Book] '{0}' by {1} for {2}", Titel, Auteur, TotaalPrijs));
        }


    }
}
