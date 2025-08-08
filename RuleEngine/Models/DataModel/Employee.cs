namespace RuleEngine.Models.DataModel;

public class Employee
{
    public uint Age { get; init; }
    public IReadOnlyList<Experience> Experiences { get; init; }= new List<Experience>();
}