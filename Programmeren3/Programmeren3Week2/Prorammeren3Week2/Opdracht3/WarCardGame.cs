using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class WarCardGame : CardGame
    {
        public Player p1;
        public Player p2;
        public WarCardGame(Player p1, Player p2)
        {

            this.p1 = p1;
            this.p2 = p2;
        }

        public void StartNewGame()
        {
            pile.Shuffle();
            int i = 0;
            foreach (PlayingCard card in pile.deck)
            {
                if(i % 2 == 0)
                {
                    p1.AddCard(card);
                }
                else
                {
                    p2.AddCard(card);
                }
                i++;
            }
        }

        public void NextCard()
        {
            PlayingCard cardP1 = p1.GetNextCard();
            PlayingCard cardP2 = p2.GetNextCard();

            if((int)cardP1.rank < (int)cardP2.rank)
            {
                Console.WriteLine(String.Format("{0} vs. {1}, {2} wins!", cardP1.ToString(), cardP2.ToString(), p2.name));
                p2.hand.Add(cardP1);
                p2.hand.Add(cardP2);
            }
            if ((int)cardP1.rank > (int)cardP2.rank)
            {
                Console.WriteLine(String.Format("{0} vs. {1}, {2} wins!", cardP1.ToString(), cardP2.ToString(), p1.name));
                p1.hand.Add(cardP1);
                p1.hand.Add(cardP2);
            }

            if (cardP1.rank == cardP2.rank)
            {
                Console.WriteLine(String.Format("{0} vs. {1}, Nobody wins!", cardP1.ToString(), cardP2.ToString()));
            }

        }

        public bool EndOfGame()
        {
            return (p1.hand.Count == 0 || p2.hand.Count == 0);
        }

            
    }
}
