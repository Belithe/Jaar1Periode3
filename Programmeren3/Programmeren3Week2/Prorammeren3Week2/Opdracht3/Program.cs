using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        void Start()
        {
            Player player1 = new Player("John"); 
            Player player2 = new Player("Emma");

            // create game and play it             
            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
        } 

        void PlayTheGame(WarCardGame war)
            {
            war.StartNewGame(); 
            while (!war.EndOfGame())
            { 
                war.NextCard(); 
            }

            if(war.p1.hand.Count == 0)
            {
                Console.WriteLine(war.p2.name + "has won!");
            } else
            {
                Console.WriteLine(war.p1.name + "has won.");
            }
             
                // TODO: display who has won the game...         } 


            }
        }
    }

