using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class Player
    {
        public string name;
        public List<PlayingCard> hand = new List<PlayingCard>();

        public Player(string name)
        {
            this.name = name;
        }
        public void AddCard(PlayingCard card)
        {
            hand.Add(card);
        }

        public PlayingCard GetNextCard()
        {
            PlayingCard cardToGive = hand[0];
            hand.RemoveAt(0);
            return cardToGive;
        }
    }
}
