namespace BuilderPattern;

public class OrderBuilder
{
    private List<IProduct> Products { get; set; } = new List<IProduct>();

    public OrderBuilder AddBurger(Burger burger)
    {
        Products.Add(burger);
        return this;
    }

    public OrderBuilder AddColdDrink(ColdDrink coldDrink)
    {
        Products.Add(coldDrink);
        return this;
    }

    public Order Build() => new Order(Products);
}
