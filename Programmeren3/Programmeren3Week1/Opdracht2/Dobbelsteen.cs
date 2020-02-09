using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class Dobbelsteen
    {
        public int waarde;
        public Random rnd;

        public Dobbelsteen(Random rnd)
        {
            this.rnd = new Random();
        }
        public void Gooi()
        {
            waarde = rnd.Next(1, 7);
        }

        public void ToonWaarde()
        {
            Console.Write(String.Format("{0} ", waarde));
        }
    }
}
