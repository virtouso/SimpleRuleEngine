using RuleEngine.Models.DataModel;

namespace RuleEngine.Models.Algorithm.Rules.Basic;

public class IsEmployeeInGivenAge(int goalAge) : BaseRule
{

    private int _goalAge = goalAge;

    public override (bool, object) Validate(object input)
    {
      var modeledInput= (Employee)input;
      return (modeledInput.Age == _goalAge, modeledInput);
    }
}