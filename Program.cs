using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            int BankLevel;
            int CrewLevel = 0;
            int Counter;
            int Success = 0;
            int Fail = 0;
            List<TeamMember> HeistTeam = new List<TeamMember>();
            double courage;
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("---------");

            Console.WriteLine("How difficult is this bank? ");
            BankLevel = int.Parse(Console.ReadLine());

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

            while(true)
            {
                Console.WriteLine("How many times would you like to run the test scenario?");
                Counter = int.Parse(Console.ReadLine());

                if (Counter > 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        

            HeistTeam.ForEach(x => {
                CrewLevel += x.Skill;
            });

            while (Counter > 0)
            {
            int Luck = RollTheDice();
            if (CrewLevel > (BankLevel + Luck))
            {
                Console.WriteLine("You did it! You robbed the bank! Now for the escape, good luck ;)");
                Success++;
            } else if ((BankLevel + Luck) > CrewLevel)
            {
                Console.WriteLine("Oof. Busted. Better luck next time in 5 - 10 years... Wait, where's Jacob?");
                Fail++;
            } else
            {
                Console.WriteLine("I don't know how you reached this point... maybe the world ended in the middle of your heist?");
            }
            Counter--;
            
            Console.WriteLine($"Crew Level: {CrewLevel}");
            Console.WriteLine($"Bank Level: {BankLevel + Luck}");
            }
            Console.WriteLine();
            Console.WriteLine($"Successful runs {Success}, failed runs {Fail}");
            
        }

        static int RollTheDice()
        {
            int nr = new Random().Next(-10, 10);
            return nr;
        }
    }
}
