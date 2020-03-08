using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{

    class PlayingCard
    {
        public Suit suit = new Suit();
        public Rank rank = new Rank();
        public PlayingCard(Rank rank, Suit suit)
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
