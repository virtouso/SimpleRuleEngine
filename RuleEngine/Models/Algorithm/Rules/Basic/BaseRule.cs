namespace RuleEngine.Models.Algorithm.Rules.Basic;

public abstract class BaseRule
{
    public abstract (bool valid, object dataResult) Validate(Object input);
}