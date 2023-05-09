namespace FactoryPattern;

public class ShapeFactory
{
    public IShape? CreateShape(string shapeType) => shapeType.ToLower() switch
    {
        "circle" => new Circle(),
        "rectangle" => new Rectangle(),
        _ => default(IShape)
    };
}
