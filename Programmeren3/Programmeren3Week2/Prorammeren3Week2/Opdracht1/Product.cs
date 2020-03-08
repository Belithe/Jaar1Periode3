using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Product
    {
        private string titel;
        private double prijs;
        private int count;
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }
        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }
        
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public double TotaalPrijs
        {
            get { return count * prijs; }
        }

        public Product(string titel, double prijs, int count)
        {
            this.Titel = titel;
            this.Prijs = prijs;
            Count = count;
        }

        virtual public void Print() {
        }
        
    }
}
