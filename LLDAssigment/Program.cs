// See https://aka.ms/new-console-template for more information
using LLDAssigment.Assignment1;

Console.WriteLine("Hello, World!");
TestShape();

void TestShape()
{
    Shape shape;
    Console.WriteLine("Enter shape: triangle(t) or rectangle(r) ");
    string? input = Console.ReadLine();
    Console.WriteLine("Enter height");
    double h = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter width");
    double w = Convert.ToDouble(Console.ReadLine());

    if (input == "t")
    {
        shape = new Triangle(h, w);
    }
    else
    {
        shape = new Rectangle(h, w);
    }

    shape.PrintArea(shape);
}
