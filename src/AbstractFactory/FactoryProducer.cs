namespace AbstractFactory;

public static class FactoryProducer
{
    public static AbstractFactory GetFactory(bool rounded) => rounded switch
    {
        true => new RoundedShapeFactory(),
        _ => new ShapeFactory()
    };
}
