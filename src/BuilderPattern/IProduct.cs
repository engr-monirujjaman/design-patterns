namespace BuilderPattern;

public interface IProduct
{
    string Name { get; set; }

    public double Price { get; set; }

    IPacking Packing();
}
