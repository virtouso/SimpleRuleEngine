using RuleEngine.Models.Algorithm.Rules.Basic;
using RuleEngine.Models.DataModel;

namespace RuleEngine.Models.Algorithm.Rules;

public class HasWorkedInGivenCity(string cityName) : BaseRule
{
    
    private string _cityName = cityName;

    public override (bool, object) Validate(object input)
    {
       var modeledInput= (Employee) input;

       foreach (var experience in modeledInput.Experiences)
       {
           if (experience.Employer.CityName == _cityName)
           {
               return (true, experience);
           }
       }

       return (false, null)!;

    }
}