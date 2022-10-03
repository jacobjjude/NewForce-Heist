using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            //adding inital list of potential crewmates
            Hacker woody = new Hacker();
            woody.Name = "Woody";
            woody.SkillLevel = 40;
            woody.PercentageCut = 10;

            Hacker noah = new Hacker();
            noah.Name = "Noah";
            noah.SkillLevel = 100;
            noah.PercentageCut = 30;

            Muscle ben = new Muscle();
            ben.Name = "Ben";
            ben.SkillLevel = 30;
            ben.PercentageCut = 10;

            Muscle josh = new Muscle();
            josh.Name = "Josh";
            josh.SkillLevel = 90;
            josh.PercentageCut = 30;

            LockSpecialist todd = new LockSpecialist();
            todd.Name = "Todd";
            todd.SkillLevel = 20;
            todd.PercentageCut = 5;

            LockSpecialist howard = new LockSpecialist();
            howard.Name = "Howard";
            howard.SkillLevel = 95;
            howard.PercentageCut = 25;

            rolodex.Add(woody);
            rolodex.Add(noah);
            rolodex.Add(josh);
            rolodex.Add(ben);
            rolodex.Add(todd);
            rolodex.Add(howard);

            Console.WriteLine("Plan your heist: ");
            Console.WriteLine($"Current amount of contacts: {rolodex.Count()}");

            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Add your own crew. What's their name? (Just hit enter to exit adding crew)");
                string crewName = Console.ReadLine();

                if (crewName != "")
                {
                    //Getting data for new crew member
                    Console.WriteLine("Choose your crew type. Type 'h' for hacker, 'm' for muscle, 'l' for lockpick specialist");
                    string crewType = Console.ReadLine();
                    Console.WriteLine("Crew's skill level (1-100)");
                    int crewSkillLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine("What's their cut? (1-100)");
                    int crewPercentageCut = int.Parse(Console.ReadLine());

                    //logic to add correct type of crew member

                    if (crewType == "h")
                    {
                        Hacker newMember = new Hacker();
                        newMember.Name = crewName;
                        newMember.SkillLevel = crewSkillLevel;
                        newMember.PercentageCut = crewPercentageCut;
                        rolodex.Add(newMember);
                    } else if (crewType == "m")
                    {
                        Muscle newMember = new Muscle();
                        newMember.Name = crewName;
                        newMember.SkillLevel = crewSkillLevel;
                        newMember.PercentageCut = crewPercentageCut;
                        rolodex.Add(newMember);
                    } else if (crewType == "l")
                    {
                        LockSpecialist newMember = new LockSpecialist();
                        newMember.Name = crewName;
                        newMember.SkillLevel = crewSkillLevel;
                        newMember.PercentageCut = crewPercentageCut;
                        rolodex.Add(newMember);
                    }
                } else if (crewName == "")
                {
                    break;
                }
            }
            
            //add Bank to rob
            Bank targetBank = new Bank();
            targetBank.AlarmScore = new Random().Next(0,100);
            targetBank.VaultScore = new Random().Next(0,100);
            targetBank.SecurityGuardScore = new Random().Next(0,100);
            targetBank.CashOnHand = new Random().Next(500000,1000000);

            Console.WriteLine("Case the joint:");
            Console.WriteLine("------------------------");


            //logic to find most and least secure options for banks. There has to be a better way here. Come back and refactor later.
            if (targetBank.AlarmScore > targetBank.VaultScore && targetBank.AlarmScore > targetBank.SecurityGuardScore)
            {
                Console.WriteLine("Most Secure: Alarms");
            } else if (targetBank.VaultScore > targetBank.AlarmScore && targetBank.VaultScore > targetBank.SecurityGuardScore)
            {
                Console.WriteLine("Most Secure: The Vault");
            } else if (targetBank.SecurityGuardScore > targetBank.AlarmScore && targetBank.SecurityGuardScore > targetBank.VaultScore)
            {
                Console.WriteLine("Most Secure: Security Guards");
            } else 
            {
                Console.WriteLine("Sorry, boss. Couldn't figure it out. We're goin' in blind.");
            }

            if (targetBank.AlarmScore < targetBank.VaultScore && targetBank.AlarmScore < targetBank.SecurityGuardScore)
            {
                Console.WriteLine("Least Secure: Alarms");
            } else if (targetBank.VaultScore < targetBank.AlarmScore && targetBank.VaultScore < targetBank.SecurityGuardScore)
            {
                Console.WriteLine("Least Secure: The Vault");
            } else if (targetBank.SecurityGuardScore < targetBank.AlarmScore && targetBank.SecurityGuardScore < targetBank.VaultScore)
            {
                Console.WriteLine("Least Secure: Security Guards");
            } else 
            {
                Console.WriteLine("Sorry, boss. Couldn't figure it out. We're goin' in blind.");
            }
        }
    }
    // Commenting out Part I code. Starting fresh with Part II but leaving to reference.


    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         int BankLevel;
    //         int CrewLevel = 0;
    //         int Counter;
    //         int Success = 0;
    //         int Fail = 0;
    //         List<TeamMember> HeistTeam = new List<TeamMember>();
    //         double courage;
    //         Console.WriteLine("Plan your heist!");
    //         Console.WriteLine("---------");

    //         Console.WriteLine("How difficult is this bank? ");
    //         BankLevel = int.Parse(Console.ReadLine());

    //         while (true)
    //         {
            
    //         Console.WriteLine("Name your teammate: ");
    //         string name = Console.ReadLine();

    //         if (name == "")
    //         {
    //             break;
    //         }

    //         Console.WriteLine("Enter their skill level: ");
    //         int skill = int.Parse(Console.ReadLine());
            

    //         while(true)
    //         {
    //             Console.WriteLine("Enter their courage level (Select a number between 0.0 and 2.0): ");
    //             courage = double.Parse(Console.ReadLine());

    //             if (courage >= 0 && courage <= 2)
    //             {
    //                 break;
    //             }
    //             else
    //             {
    //                 continue;
    //             }
    //         }

    //         TeamMember Fodder = new TeamMember(){
    //             Name = name,
    //             Skill = skill,
    //             Courage = courage
    //         };

    //         HeistTeam.Add(Fodder);
    //         }

    //         while(true)
    //         {
    //             Console.WriteLine("How many times would you like to run the test scenario?");
    //             Counter = int.Parse(Console.ReadLine());

    //             if (Counter > 0)
    //             {
    //                 break;
    //             }
    //             else
    //             {
    //                 continue;
    //             }
    //         }
        

    //         HeistTeam.ForEach(x => {
    //             CrewLevel += x.Skill;
    //         });

    //         while (Counter > 0)
    //         {
    //         int Luck = RollTheDice();
    //         if (CrewLevel > (BankLevel + Luck))
    //         {
    //             Console.WriteLine("You did it! You robbed the bank! Now for the escape, good luck ;)");
    //             Success++;
    //         } else if ((BankLevel + Luck) > CrewLevel)
    //         {
    //             Console.WriteLine("Oof. Busted. Better luck next time in 5 - 10 years... Wait, where's Jacob?");
    //             Fail++;
    //         } else
    //         {
    //             Console.WriteLine("I don't know how you reached this point... maybe the world ended in the middle of your heist?");
    //         }
    //         Counter--;
            
    //         Console.WriteLine($"Crew Level: {CrewLevel}");
    //         Console.WriteLine($"Bank Level: {BankLevel + Luck}");
    //         }
    //         Console.WriteLine();
    //         Console.WriteLine($"Successful runs {Success}, failed runs {Fail}");
            
    //     }

    //     static int RollTheDice()
    //     {
    //         int nr = new Random().Next(-10, 10);
    //         return nr;
    //     }
    // }
}
