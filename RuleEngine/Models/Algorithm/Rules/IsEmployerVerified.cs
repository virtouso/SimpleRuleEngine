using RuleEngine.Models.DataModel;

namespace RuleEngine.Models.Algorithm.Rules.Basic;

public class IsEmployerVerified: BaseRule
{
    public override (bool, object) Validate(object input)
    {
        var modeledInput = (Experience)input;

    var verified= modeledInput.Employer.Verified == true;
    return (verified, modeledInput);
    }
}