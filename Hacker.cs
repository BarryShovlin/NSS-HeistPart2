using System;
using System.Threading;

public class Hacker : IRobber
{
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentCut { get; set; }
    public int Id { get; set; }
    public void PerformSkill(Bank bank)
    {
        int HackerSkill = bank.AlarmScore - SkillLevel;
        Console.WriteLine($"{Name} is attempting to cut the bank's alarm system.");
        Thread.Sleep(1500);
        if (bank.AlarmScore <= 0)
        {
            Console.WriteLine($"{Name}'s done it again!  Alarm has been disabled.");
        }
    }
    public void skillSet()
    {
        Console.WriteLine("Hacker");
    }




}