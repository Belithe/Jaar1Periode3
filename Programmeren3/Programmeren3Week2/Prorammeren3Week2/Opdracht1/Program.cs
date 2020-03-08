using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program meme = new Program();
            meme.Start();
        }

        void Start()
        {
            Boekhandel boekhandel = new Boekhandel();

            boekhandel.VoegToe(new Boek("James Weird", "John Died In A Fire", 5.50, 5));
            boekhandel.VoegToe(new Tijdschrift("History for Losers", "5/2/1998", 3.00, 7));


            boekhandel.PrintVoorraad();
        }

    }
}
