namespace SingletonPattern;

public class Car
{
    private static readonly Car _car = new Car();

    private DateTime CreateTime { get; set; }

    private Car()
    {
        CreateTime = DateTime.Now;
    }

    public static Car Create() => _car;

    public override string ToString() => CreateTime.ToString("s");
}
