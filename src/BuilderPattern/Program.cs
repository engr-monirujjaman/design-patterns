
using BuilderPattern;

var order = new OrderBuilder()
    .AddBurger(new ChickenBurger())
    .AddColdDrink(new Pepsi())
    .Build();

order.ShowProducts();
