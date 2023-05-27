using System.Text.Json;
using FilterPattern;

var persons = new List<Person>
{
    new Person("Robert", "Male", "Single"),
    new Person("John", "Male", "Married"),
    new Person("Laura", "Female", "Married"),
    new Person("Diana", "Female", "Single"),
    new Person("Mike", "Male", "Single"),
    new Person("Bobby", "Male", "Single")
};


Console.WriteLine("Males");
var male = new CriteriaMale();
PrintPersons(male.MeetCriteria(persons));

Console.WriteLine("Females");
var female = new CriteriaFemale();
PrintPersons(female.MeetCriteria(persons));

Console.WriteLine("Singles");
var single = new CriteriaSingle();
PrintPersons(single.MeetCriteria(persons));

Console.WriteLine("Marrieds");
var married = new CriteriaMarried();
PrintPersons(married.MeetCriteria(persons));


Console.WriteLine("Single Or Females");
var singleOrFemale = new OrCriteria(single, female);
PrintPersons(singleOrFemale.MeetCriteria(persons));

Console.WriteLine("Single And Female");
var singleAndFemale = new AndCriteria(single, female);
PrintPersons(singleAndFemale.MeetCriteria(persons));
return;

static void PrintPersons(List<Person> persons)
{
    Console.WriteLine(JsonSerializer.Serialize(persons, new JsonSerializerOptions
    {
        WriteIndented = true
    }));

    Console.WriteLine();
}