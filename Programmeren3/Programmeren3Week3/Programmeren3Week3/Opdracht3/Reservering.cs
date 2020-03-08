using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class Reservering
    {
        public Klant KlantMetReservering { get; set; }

        public List<Kaartje> Kaartenlijst { get; set; }

        public decimal TotaalPrijs
        {
            get
            {
                decimal prijsToCalc = 0;
                decimal modifier = 1;
                foreach (Kaartje kaartje in Kaartenlijst)
                {
                    if (kaartje.Korting == true)
                    {
                        modifier -= (decimal)0.05;
                    } 
                    if (KlantMetReservering.RechtOpKorting == true)
                    {
                        modifier -= (decimal)0.1;
                    }
                    prijsToCalc += kaartje.Prijs * modifier;
                }
                return prijsToCalc;
            }
        }

        public Reservering(Klant klant, List<Kaartje> kaartList) 
        {
            KlantMetReservering = klant;
            Kaartenlijst = kaartList;
        }
    }
}
