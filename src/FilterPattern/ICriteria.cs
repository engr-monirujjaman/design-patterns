namespace FilterPattern;

public interface ICriteria
{
    List<Person> MeetCriteria(List<Person> persons);
}