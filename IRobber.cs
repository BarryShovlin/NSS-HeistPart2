public interface IRobber
{
    string Name { get; set; }
    int SkillLevel { get; set; }
    int PercentCut { get; set; }
    int Id { get; set; }

    static void PerformSkill(Bank bank)
    {

    }
    void skillSet()
    {
    }

}