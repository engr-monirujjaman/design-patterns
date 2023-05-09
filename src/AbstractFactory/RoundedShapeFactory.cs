namespace AbstractFactory;

public class RoundedShapeFactory : AbstractFactory
{
    public override IShape? GetShape(string shapeType) => shapeType.ToLower() switch
    {
        "rectangle" => new RoundedRectangle(),
        "square" => new RoundedSquare(),
        _ => null
    };
}
