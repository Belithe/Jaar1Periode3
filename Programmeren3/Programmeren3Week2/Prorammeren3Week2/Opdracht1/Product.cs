using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Product
    {
        public string titel;
        public double prijs;

        public Product(string titel, double prijs)
        {
            this.titel = titel;
            this.prijs = prijs;
        }

        virtual public void Print() {
        }
        
    }
}
