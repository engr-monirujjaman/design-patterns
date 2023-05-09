namespace AbstractFactory;

public class ShapeFactory : AbstractFactory
{
    public override IShape? GetShape(string shapeType) => shapeType.ToLower() switch
    {
        "rectangle" => new Rectangle(),
        "square" => new Square(),
        _ => null
    };
}
