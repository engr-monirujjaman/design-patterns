
using AbstractFactory;

var shapeFactory = FactoryProducer.GetFactory(false);

var shape1 = shapeFactory.GetShape("rectangle");
shape1?.Draw();

var roundedShapeFactory = FactoryProducer.GetFactory(true);
var shape2 = roundedShapeFactory.GetShape("square");
shape2?.Draw();
