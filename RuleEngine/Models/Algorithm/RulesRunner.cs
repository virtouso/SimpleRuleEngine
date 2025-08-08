using System.Data;
using RuleEngine.Models.Algorithm.Rules.Basic;
using RuleEngine.Models.DataModel;

namespace RuleEngine.Models.Algorithm;

public class RulesRunner
{
    public RulesRunner(Employee employee, params BaseRule[] rules)
    {
        _employee = employee;
        _rules = rules.ToList();
    }

    private Employee _employee;
    private List<BaseRule> _rules;


    public (bool isValid, int stepNumber) Validate()
    {
        int counter = 0;
        object input = _employee;


        foreach (BaseRule rule in _rules)
        {
            var result = rule.Validate(input);

            if (!result.valid)
            {
                return (false, counter);
            }

            input = result.dataResult;
            counter++;
        }
        
        
        return (true, -1);
    }
    
    
}