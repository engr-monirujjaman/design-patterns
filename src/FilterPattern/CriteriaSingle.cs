namespace FilterPattern;

public class CriteriaSingle : ICriteria
{
    public List<Person> MeetCriteria(List<Person> persons) =>
        persons
            .Where(x => x.MaritalStatus.Equals("single", StringComparison.OrdinalIgnoreCase))
            .ToList();
}