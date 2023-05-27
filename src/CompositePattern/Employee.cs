namespace CompositePattern;

public class Employee
{
    public Employee(string name, string dept, int salary)
    {
        Name = name;
        Dept = dept;
        Salary = salary;
        Subordinates = new List<Employee>();
    }

    public string Name { get; set; }

    public string Dept { get; set; }

    public int Salary { get; set; }

    private List<Employee> Subordinates { get; set; }

    public void Add(Employee employee) => Subordinates.Add(employee);

    public void Remove(Employee employee) => Subordinates.Remove(employee);

    public List<Employee> GetSubordinates() => Subordinates;

    public override string ToString()
    {
        return $"Employee: [ Name: {Name}, Dept: {Dept}, Salary: {Salary} ]";
    }
}