using FactoryPattern;

var shapeFactory =  new ShapeFactory();

var circle = shapeFactory.CreateShape("circle");

var rectangle = shapeFactory.CreateShape("rectangle");

circle?.Draw();
rectangle?.Draw();
