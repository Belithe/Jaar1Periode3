using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Opdracht_1
{
    class Team
    {
        public List<Programmer> programmers;

        public Team()
        {
            programmers = new List<Programmer>();
        }

        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }

        public void PrintAllTeamMembers()
        {
            foreach (Programmer p in programmers)
            {
                Console.WriteLine(String.Format("Naam: {0} Specialty: {1}", p.name, p.specialty.ToString()));

            }
        }
    }
}
