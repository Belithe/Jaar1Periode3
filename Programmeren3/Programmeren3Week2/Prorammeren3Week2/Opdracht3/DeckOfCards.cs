using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class DeckOfCards
    {
        public List<PlayingCard> deck = new List<PlayingCard>();
        public DeckOfCards()
        {
            InitCards();
        }

        private void InitCards()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    
                        deck.Add(new PlayingCard((Rank)j, (Suit)i));
                    
                }
            }
        }

        public void Print()
        {
            foreach (PlayingCard playingCard in deck)
            {
                Console.WriteLine(playingCard.ToString());
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();

            for (int i = 0; i < deck.Count; i++)
            {
                int rndPos = rnd.Next(deck.Count);
                PlayingCard currCard = deck[rndPos];
                deck[rndPos] = deck[i];
                deck[i] = currCard;
            }
        }
    }
}
