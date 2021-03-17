using System;
using System.Collections.Generic;
using System.Threading;

namespace HeistPartII
{
    class Program
    {


        static void Main(string[] args)
        {

            Bank SouthBank = new Bank();

            Hacker hacker = new Hacker();

            Muscle muscle = new Muscle();

            LockSpecialist lockSpecialist = new LockSpecialist();

            List<IRobber> rolodex = new List<IRobber>()
            {
                hacker, muscle, lockSpecialist
            };
            bool teamAssemble = true;
            while (teamAssemble)
            {

                Console.WriteLine($"{rolodex.Count}");
                Console.WriteLine("Please enter the name of a new operative");
                Console.Write(">");
                string newOpName = Console.ReadLine();
                int newOpSpec()
                {
                    Console.WriteLine("Select the operative's specialty");
                    Console.WriteLine("[1] Hacker (Disables alarms)");
                    Console.WriteLine("[2] Muscle (Takes out the guards)");
                    Console.WriteLine("[3] Lock Specialist (Cracks the vault)");
                    string newOpSpecSelect = Console.ReadLine();
                    try
                    {
                        int newOpSpecialty = Int32.Parse(newOpSpecSelect);
                        if (newOpSpecialty > 3)
                        {
                            Console.WriteLine("Enter a number between 1 and 3");
                            newOpSpec();
                        }
                        else
                            return newOpSpecialty;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter 1, 2, or 3");
                        newOpSpec();
                    }
                    return 0;
                }
                int returnedSpecialty = newOpSpec();

                Console.WriteLine($"Enter {newOpName}'s skill level");
                string newOpski = Console.ReadLine();
                int newOpSkill = Int32.Parse(newOpski);

                Console.WriteLine($"What percentage of each heist is {newOpName}'s cut?");
                string cut = Console.ReadLine();
                int newOpCut = Int32.Parse(cut);

                if (returnedSpecialty == 1)
                {
                    hacker.Name = newOpName;
                    hacker.SkillLevel = newOpSkill;
                    hacker.PercentCut = newOpCut;
                    rolodex.Add(hacker);
                }
                else if (returnedSpecialty == 2)
                {
                    muscle.Name = newOpName;
                    muscle.SkillLevel = newOpSkill;
                    muscle.PercentCut = newOpCut;
                    rolodex.Add(muscle);
                }
                else
                {
                    lockSpecialist.Name = newOpName;
                    lockSpecialist.SkillLevel = newOpSkill;
                    lockSpecialist.PercentCut = newOpCut;
                    rolodex.Add(lockSpecialist);

                }
                Console.WriteLine("Would you like to add another operative? [y/n]");
                Console.Write(">");
                string addOn = Console.ReadLine();
                if (addOn != "y")
                {
                    teamAssemble = false;
                }
            }
            Random alarm = new Random();
            Random vault = new Random();
            Random security = new Random();
            Random cash = new Random();

            Bank rando = new Bank();
            rando.AlarmScore = alarm.Next(0, 100);
            rando.VaultScore = vault.Next(0, 100);
            rando.SecurityGuardScore = security.Next(0, 100);
            rando.CashOnHand = cash.Next(50000, 1000000);

            Console.WriteLine("Lets check out the intel on this bank...");
            Thread.Sleep(1700);

            if (rando.AlarmScore > rando.VaultScore && rando.AlarmScore > rando.SecurityGuardScore)
            {
                Console.WriteLine("Most secure: Alarm");
            }
            else if (rando.VaultScore > rando.AlarmScore && rando.VaultScore > rando.SecurityGuardScore)
            {
                Console.WriteLine("Most secure: Vault");
            }
            else if (rando.SecurityGuardScore > rando.AlarmScore && rando.SecurityGuardScore > rando.VaultScore)
            {
                Console.WriteLine("Most secure: Security Guard");
            };

            if (rando.AlarmScore < rando.VaultScore && rando.AlarmScore < rando.SecurityGuardScore)
            {
                Console.WriteLine("Least secure: Alarm");
            }
            else if (rando.VaultScore < rando.AlarmScore && rando.VaultScore < rando.SecurityGuardScore)
            {
                Console.WriteLine("Least secure: Vault");
            }
            else if (rando.SecurityGuardScore < rando.AlarmScore && rando.SecurityGuardScore < rando.VaultScore)
            {
                Console.WriteLine("Least secure: Security Guard");
            }



        }

    }
}
