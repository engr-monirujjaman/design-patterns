namespace FilterPattern;

public class AndCriteria : ICriteria
{
    private readonly ICriteria _criteria;
    private readonly ICriteria _otherCriteria;

    public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
    {
        _criteria = criteria;
        _otherCriteria = otherCriteria;
    }

    public List<Person> MeetCriteria(List<Person> persons) =>
        _otherCriteria
            .MeetCriteria(_criteria
                .MeetCriteria(persons));
}