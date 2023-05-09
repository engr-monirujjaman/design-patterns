namespace BuilderPattern;

public abstract class Burger : IProduct
{
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public IPacking Packing() => new Wrapper();
}
