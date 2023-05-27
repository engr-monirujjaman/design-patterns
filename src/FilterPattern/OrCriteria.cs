namespace FilterPattern;

public class OrCriteria : ICriteria
{
    private readonly ICriteria _criteria;
    private readonly ICriteria _otherCriteria;

    public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
    {
        _criteria = criteria;
        _otherCriteria = otherCriteria;
    }

    public List<Person> MeetCriteria(List<Person> persons)
    {
        var first = _criteria
            .MeetCriteria(persons);

        first.AddRange(_otherCriteria.MeetCriteria(persons));

        return first.DistinctBy(x => x).ToList();
    }
}