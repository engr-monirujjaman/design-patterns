namespace BuilderPattern;

public abstract class ColdDrink : IProduct
{
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public IPacking Packing() => new Bottle();
}
