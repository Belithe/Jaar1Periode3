using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class Klant
    {
        private string name;
        private DateTime bd;
        private DateTime reg;

        public DateTime Reg
        {
            get { return reg; }
            private set { reg = value; }
        }

        public string Name { 
            get { return name; }
            set { 
                if (value != "") {
                    name = value;
                }
            } 
        }

        public DateTime BD
        {
            get { return bd; }
            set
            {
                if (value > DateTime.Today || value < new DateTime(1920, 1, 1))
                {
                    Console.WriteLine("Invalid birthdate.");
                } else { bd = value; }
            }
        }

        public int Leeftijd
        {
            get
            {                
                return (int)((DateTime.Today - BD).TotalDays)/356;
            }
        }

        public bool RechtOpKorting
        {
            get 
            {
                return ((DateTime.Today - Reg).TotalDays / 356 >= 1);
            }
            
        }

        public Klant()
        {
            Reg = new DateTime(2005, 10, 10);
        }
       
    }
}
