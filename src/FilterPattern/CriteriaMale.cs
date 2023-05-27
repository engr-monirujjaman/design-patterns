namespace FilterPattern;

public class CriteriaMale : ICriteria
{
    public List<Person> MeetCriteria(List<Person> persons) =>
        persons
            .Where(x => x.Gender.Equals("male", StringComparison.OrdinalIgnoreCase))
            .ToList();
}