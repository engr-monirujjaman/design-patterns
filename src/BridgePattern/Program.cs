
using BridgePattern;

var redCircle = new Circle(100, 100, 10, new RedCircle());
var greenCircle = new Circle(100, 100, 10, new GreenCircle());

redCircle.Draw();
greenCircle.Draw();