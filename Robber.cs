using System;

namespace heist
{
    public interface IRobber
    {
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}
        public void PerformSkill(Bank bank)
        {

        }
    }

    public class Hacker : IRobber
    {
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - this.SkillLevel;
            Console.WriteLine($"{this.Name} is hacking the alarm system. Decreased security by {this.SkillLevel} points");

            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{this.Name} has disabled the alarm system!");
            }
        }
    }

    public class Muscle : IRobber
    {
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - this.SkillLevel;
            Console.WriteLine($"{this.Name} is beating up the security guards");

            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{this.Name} has knocked all the security guards unconscious!");
            }
        }
    }

    public class LockSpecialist : IRobber
    {
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - this.SkillLevel;
            Console.WriteLine($"{this.Name} is picking the vault lock. Decreased by {this.SkillLevel} points");

            if (bank.VaultScore <=0)
            {
                Console.WriteLine($"{this.Name} has cracked the vault!");
            }
        }
        
    }
}