namespace PrototypePattern;

public class Shape
{
    public Shape()
    {

    }

    private Shape(Shape shape)
    {
        Name = shape.Name;
    }

    public string Name { get; set; } = string.Empty;

    public Shape Clone() => new Shape(this);
}
