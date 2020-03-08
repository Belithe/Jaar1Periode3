using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Boekhandel
    {
        List<Product> inventory = new List<Product>();

        public void VoegToe(Product productToAdd)
        {
            this.inventory.Add(productToAdd);
        }
        public void PrintVoorraad()
        {

            foreach (Product product in this.inventory)
            {
                product.Print();
            }
        }
    }
}
