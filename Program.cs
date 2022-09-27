using System;
using System.Collections.Generic;

namespace heist_example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> HeistTeam = new List<TeamMember>();
            double courage;
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("---------");

            while (true)
            {
            
            Console.WriteLine("Name your teammate: ");
            string name = Console.ReadLine();

            if (name == "")
            {
                break;
            }

            Console.WriteLine("Enter their skill level: ");
            int skill = int.Parse(Console.ReadLine());
            

            while(true)
            {
                Console.WriteLine("Enter their courage level (Select a number between 0.0 and 2.0): ");
                courage = double.Parse(Console.ReadLine());

                if (courage >= 0 && courage <= 2)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            TeamMember Fodder = new TeamMember(){
                Name = name,
                Skill = skill,
                Courage = courage
            };

            HeistTeam.Add(Fodder);
            }

            Console.WriteLine($"Here's the suckers... *cough cough*, I mean crew ({HeistTeam.Count})");
            Console.WriteLine("-----------------");
            HeistTeam.ForEach(x => {
                Console.WriteLine($"Name: {x.Name}");
                Console.WriteLine($"Skill: {x.Skill}");
                Console.WriteLine($"Courage: {x.Courage}");
                Console.WriteLine();
            });
        }
    }
}
