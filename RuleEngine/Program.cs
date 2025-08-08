// See https://aka.ms/new-console-template for more information

using RuleEngine.Models.Algorithm;
using RuleEngine.Models.Algorithm.Rules;
using RuleEngine.Models.Algorithm.Rules.Basic;
using RuleEngine.Models.DataModel;



var TractorSazan = new Employer { CityName = "tehran", Verified = true,  UniqueName = "tractor_sazan"};
var TadbirPazhohan= new Employer{CityName = "esfahan", Verified = false,  UniqueName="tadbir_pazhohan"};
var Binagoon = new Employer { CityName = "alborz", Verified = false, UniqueName="binagoon"};


// rule system 1

var employee1 = new Employee{Age = 25, Experiences = new List<Experience>
{
    new Experience { Employer =  TractorSazan, StartDate = new DateTime(2020,10,10), EndDate = new DateTime(2021,10,10), },
    new Experience { Employer =  TractorSazan, StartDate = new DateTime(2021,10,10), EndDate = new DateTime(2022,10,10), },
    new Experience { Employer =  TractorSazan, StartDate = new DateTime(2023,10,10), EndDate = new DateTime(2024,10,10), },
}};

var runner1 = new RulesRunner(employee1,new HasWorkedInGivenCity("tehran"), new IsExperienceMoreThanGivenYearsCount(1),new IsEmployerVerified());

var runner1Result = runner1.Validate();


Console.WriteLine($"rules1 is valid:{runner1Result.isValid}, validation Step:{runner1Result.stepNumber}" );


// rule system 2


var employee2 = new Employee{Age = 45, Experiences = new List<Experience>
{
    new Experience { Employer =  TractorSazan, StartDate = new DateTime(2020,10,10), EndDate = new DateTime(2021,10,10), },
    new Experience { Employer =  TractorSazan, StartDate = new DateTime(2021,10,10), EndDate = new DateTime(2022,10,10), },
    new Experience { Employer =  TractorSazan, StartDate = new DateTime(2023,10,10), EndDate = new DateTime(2024,10,10), },
}};

var runner2 = new RulesRunner(employee1,new IsEmployeeInGivenAge(46), new DoesEmployeeHaveMinimumExperience(3));

var runner2Result = runner2.Validate();


Console.WriteLine($"rules2 is valid:{runner2Result.isValid}, validation Step:{runner2Result.stepNumber}" );
