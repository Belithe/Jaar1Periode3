using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{
    class DeckOfCards
    {
        List<PlayingCard> deck = new List<PlayingCard>();
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
                    if(j > 10 || j == 1)
                    {
                        switch (j)
                        {
                            case (1): deck.Add(new PlayingCard("Ace", (Suit)i));
                                break;
                            case (11): deck.Add(new PlayingCard("Jack", (Suit)i));
                                break;
                            case (12): deck.Add(new PlayingCard("Queen", (Suit)i));
                                break;
                            case (13): deck.Add(new PlayingCard("King", (Suit)i));
                                break;
                        }
                    } else
                    {
                        deck.Add(new PlayingCard(j.ToString(), (Suit)i));
                    }
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
