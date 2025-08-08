using RuleEngine.Models.Algorithm.Rules.Basic;
using RuleEngine.Models.DataModel;

namespace RuleEngine.Models.Algorithm.Rules;

public class IsExperienceMoreThanGivenYearsCount(int yearsCount) : BaseRule
{
    private int _yearsCount = yearsCount;

    public override (bool, object) Validate(object input)
    {
        var modeledInput = (Experience)input;

        var dateWithAddedYears = modeledInput.StartDate.AddYears(_yearsCount);
        if (dateWithAddedYears >= modeledInput.EndDate) return (true, modeledInput);

        return (false, null)!;
    }
}