using System;
using System.Threading;

public class LockSpecialist : IRobber
{
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentCut { get; set; }
    public void PerformSkill(Bank bank)
    {
        int LockSkill = bank.VaultScore - SkillLevel;
        Console.WriteLine($"{Name} is going to attempt to crack the vault.");
        Thread.Sleep(1500);
        if (bank.VaultScore <= 0)
        {
            Console.WriteLine($"{Name} has successfully broken into the vault");
        }
    }


}