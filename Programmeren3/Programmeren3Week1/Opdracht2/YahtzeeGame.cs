using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class YahtzeeGame
    {
        public Dobbelsteen[] dobbelsteenList = new Dobbelsteen[5];
        
        public YahtzeeGame()
        {
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                dobbelsteenList[i] = new Dobbelsteen(rnd);

            }
        }

        public void Gooi()
        {
            for (int i = 0; i < dobbelsteenList.Length; i++)
            {
                dobbelsteenList[i].Gooi();
            }
            Console.WriteLine();
        }

        public void ToonWorp()
        {
            for (int i = 0; i < dobbelsteenList.Length; i++)
            {
                dobbelsteenList[i].ToonWaarde();
            }
        }

        public bool Yahtzee()
        {

            for (int i = 0; i < dobbelsteenList.Length; i++)
            {
                if (!(dobbelsteenList[0].waarde == dobbelsteenList[i].waarde))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
