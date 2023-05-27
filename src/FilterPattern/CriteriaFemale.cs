namespace FilterPattern;

public class CriteriaFemale : ICriteria
{
    public List<Person> MeetCriteria(List<Person> persons) =>
        persons
            .Where(x => x.Gender.Equals("female", StringComparison.OrdinalIgnoreCase))
            .ToList();
}