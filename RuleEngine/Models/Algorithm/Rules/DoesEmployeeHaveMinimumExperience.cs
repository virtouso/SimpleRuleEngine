using RuleEngine.Models.Algorithm.Rules.Basic;
using RuleEngine.Models.DataModel;

namespace RuleEngine.Models.Algorithm.Rules;

public class DoesEmployeeHaveMinimumExperience(uint minimumExperienceYears) : BaseRule
{
    private readonly uint _minimumExperienceYears = minimumExperienceYears;

    public override (bool, object) Validate(object input)
    {
        var modeledInput = (Employee)input;

        double experienceDays = modeledInput.Experiences.Sum(x => (x.EndDate - x.StartDate).TotalDays);
        double experienceYears = (experienceDays / 365);
        
        return (experienceYears >= _minimumExperienceYears, modeledInput);
    }
}