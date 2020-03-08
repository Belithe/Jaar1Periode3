using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class Kaartje
    {

        Exception invalid = new Exception("Error ocurred, invalid input.");

        private string filmNaam;
        private int zaal;
        private DateTime aanvangstTijd;
        private decimal prijs;
        private int minimumLeeftijd;

        public string FilmNaam
        {
            get { return filmNaam; }
            set
            {
                if (value != "") { filmNaam = value; } else { throw invalid; }
            }
        }
        public int Zaal
        {
            get { return zaal; }
            set
            {
                if (!(value > 5 || value < 1)) { zaal = value; } else { throw invalid; } 
            }
        }
        public DateTime AanvangstTijd { 
            get {return aanvangstTijd; } 
            set 
            {
                if(value.TimeOfDay.TotalMinutes % 30 == 0) { aanvangstTijd = value; } else { throw invalid; }
            } 
        }
        public decimal Prijs { get; set; }
        public int MinimumLeeftijd
        {
            get { return minimumLeeftijd; }
            set
            {
                if (value == 0 || value == 6 || value == 9 || value == 12 || value == 16) { minimumLeeftijd = value; } else { throw invalid; }
            }
        }

        public bool Korting
        {
            get { return (aanvangstTijd.Date.DayOfWeek == DayOfWeek.Monday || aanvangstTijd.Date.DayOfWeek == DayOfWeek.Tuesday); }
        }
    }
}
