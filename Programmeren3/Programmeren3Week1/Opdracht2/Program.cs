using System;

namespace Opdracht3
{
    class Program
    {
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            SpeelYahtzee(yahtzeeGame);
        }
        void SpeelYahtzee(YahtzeeGame game)
        {
            int aantalPogingen = 0;
            do
            {
                game.Gooi(); // gooi dobbelstenen
                game.ToonWorp(); // toon worp
                aantalPogingen++;
            } while (!game.Yahtzee());
            Console.WriteLine("Aantal pogingen nodig voor yahtzee: {0}", aantalPogingen);
        }


    }
}
