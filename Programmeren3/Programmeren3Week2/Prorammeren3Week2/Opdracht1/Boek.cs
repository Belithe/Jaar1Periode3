using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Boek : Product
    {
        private string titel;
        private string auteur;
        private double prijs;

        public Boek(string auteur, string titel, double prijs) : base(titel, prijs)
        {
            this.auteur = auteur;
        }

        public void Print(Boek boek)
        {
            Console.WriteLine(String.Format("'{0}' by {1} for {2}", boek.titel, boek.auteur, boek.prijs));

        }


    }
}
