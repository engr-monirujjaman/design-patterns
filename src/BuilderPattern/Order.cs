namespace BuilderPattern;

public class Order
{
    private List<IProduct> Products { get; set; }

    public double TotalCost => Products.Sum(x => x.Price);

    public Order(List<IProduct> products)
    {
        Products = products;
    }

    public void ShowProducts()
    {
        Products.ForEach(x =>
        {
            Console.WriteLine("Product: " + x.Name);
            Console.WriteLine("Packing: " + x.Packing().Pack());
            Console.WriteLine("Price: " + x.Price);
        });

        Console.WriteLine("Total Price: " + TotalCost);
    }
}
