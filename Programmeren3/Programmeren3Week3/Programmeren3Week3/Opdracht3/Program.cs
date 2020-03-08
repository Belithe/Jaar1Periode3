using System;
using System.Collections.Generic;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        void Start()
        {
            Klant klant = new Klant();
            klant.BD = new DateTime(1999, 8, 22);
            klant.Name = "Johnny5Guns";
            PrintKlant(klant);

            Kaartje kaartje = new Kaartje();
            kaartje.FilmNaam = "Dat was niet erg leuk";
            kaartje.AanvangstTijd = DateTime.Today;
            kaartje.MinimumLeeftijd = 6;
            kaartje.Prijs = 5;
            kaartje.Zaal = 5;
            List<Kaartje> kaartList = new List<Kaartje>();
            kaartList.Add(kaartje);

            Reservering reservering = new Reservering(klant, kaartList);

            Console.WriteLine(reservering.TotaalPrijs);
        }

        private  void PrintKlant(Klant klantToPrint)
        {
            Console.WriteLine(klantToPrint.Name);
            Console.WriteLine(klantToPrint.BD);
            Console.WriteLine(klantToPrint.Leeftijd);
            Console.WriteLine(klantToPrint.Reg);
            Console.WriteLine(klantToPrint.RechtOpKorting);
            
        }
    }
}
