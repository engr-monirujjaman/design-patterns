namespace FilterPattern;

public class CriteriaMarried : ICriteria
{
    public List<Person> MeetCriteria(List<Person> persons) =>
        persons
            .Where(x => x.MaritalStatus.Equals("married", StringComparison.OrdinalIgnoreCase))
            .ToList();
}