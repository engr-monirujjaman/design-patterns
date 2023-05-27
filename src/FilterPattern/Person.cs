namespace FilterPattern;

public class Person
{
    public string Name { get; set; } = string.Empty;

    public string Gender { get; set; } = string.Empty;

    public string MaritalStatus { get; set; } = string.Empty;

    public Person()
    {
        
    }
    
    public Person(string name, string gender, string maritalStatus)
    {
        Name = name;
        Gender = gender;
        MaritalStatus = maritalStatus;
    }
}