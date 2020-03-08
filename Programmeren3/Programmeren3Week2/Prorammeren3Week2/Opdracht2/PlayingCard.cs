using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{

    class PlayingCard
    {
        public Suit suit = new Suit();
        public string rank;
        public PlayingCard(string rank, Suit suit)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public override string ToString()
        {
            return String.Format("{0} of {1}", rank, suit);
        }

    }
}
