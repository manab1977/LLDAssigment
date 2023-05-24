using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDAssigment.Assignment1
{
    public class Shape
    {
        public double height;
        public double width;

        public Shape(double h, double w)
        {
            height= h;
            width= w;
        }
        public virtual double ComputeArea()
        {
            return 0;
        }

        public void PrintArea(Shape shape)
        {
            Console.WriteLine("Area is " + shape.ComputeArea());
        }
    }

    public class Triangle: Shape
    {
        public Triangle(double h, double w) : base(h, w)
        {
        }

        public override double ComputeArea()
        {
            return (height * width) / 2;
        }
    }

    public class Rectangle: Shape
    {
        public Rectangle(double h, double w): base(h, w)
        {
        }
        public override double ComputeArea()
        {
            return (height * width);
        }
    }
}
