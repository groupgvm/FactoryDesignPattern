interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Draw a Circle\n");
    }
}

class Rectangle: IShape
{
    public void Draw()
    {
        Console.WriteLine("Draw a Rectangle\n");
    }
}

class Triangle: IShape
{
    public void Draw()
    {
        Console.WriteLine("Draw a Triangle\n");
    }
}

abstract class ShapeFactory
{
    public abstract IShape createShape(string shape);
}

class ConcreteShapeFactory : ShapeFactory
{
    public override IShape createShape(string shape)
    {
        switch(shape)
        {
            case "1":
                return new Circle();
            case "2":
                return new Rectangle();
            case "3":
                return new Triangle();
            default:
                throw new Exception();

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShapeFactory shapeFactory = new ConcreteShapeFactory();

        while (true)
        {
            Console.WriteLine("Select what you want to draw");
            Console.WriteLine("1) Circle");
            Console.WriteLine("2) Rectangle");
            Console.WriteLine("3) Triangle\n");
            var input = Console.ReadLine();

            IShape shape = shapeFactory.createShape(input ?? "");
            shape.Draw();

        }
    }
}
