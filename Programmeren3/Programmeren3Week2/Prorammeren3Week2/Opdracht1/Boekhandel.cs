using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class Boekhandel
    {
        List<Boek> boekenLijst = new List<Boek>();

        public void VoegToe(Boek boekToAdd)
        {
            this.boekenLijst.Add(boekToAdd);
        }
        public void PrintVoorraad()
        {
            foreach (Boek boek in this.boekenLijst)
            {
                boek.Print(boek);
            }
        }
    }
}
