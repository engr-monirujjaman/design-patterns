
using SingletonPattern;

var car1 = Car.Create();
Console.WriteLine(car1.ToString());

var car2 = Car.Create();
Console.WriteLine(car2.ToString());

var car3 = Car.Create();
Console.WriteLine(car3.ToString());
