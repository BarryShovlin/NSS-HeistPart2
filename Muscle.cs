using System;
using System.Threading;

public class Muscle : IRobber
{
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentCut { get; set; }
    public void PerformSkill(Bank bank)
    {
        int MusclePerformance = bank.SecurityGuardScore - SkillLevel;
        Console.WriteLine($"{Name} is going to try and eliminate the Security guard threat.");
        Thread.Sleep(1500);
        if (bank.SecurityGuardScore <= 0)
        {
            Console.WriteLine($"{Name} has taken out the security guard with a roundhouse kick!!");
        }
    }
    public void skillSet()
    {
        Console.WriteLine("Muscle");
    }
}