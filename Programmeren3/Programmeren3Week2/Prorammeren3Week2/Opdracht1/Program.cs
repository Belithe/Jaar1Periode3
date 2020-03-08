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

            boekhandel.VoegToe(new Boek("John Died In A Fire", "James Weird", 5.50));

            boekhandel.PrintVoorraad();
        }

    }
}
