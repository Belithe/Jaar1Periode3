using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Programmer Rick = new Programmer("Rick", Specialty.Csharp);
            Programmer Number9Large = new Programmer("Number9", Specialty.PHP);
            Programmer LoserFace = new Programmer("Loser");

            Team team = new Team();

            team.AddProgrammer(Rick);
            team.AddProgrammer(Number9Large);
            team.AddProgrammer(LoserFace);

            team.PrintAllTeamMembers();

        }
    }
}
