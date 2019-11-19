using System;
using ShapesVisitor.Shapes;

namespace ShapesVisitor.ShapesVisitors
{
    public class ShapeDescriptor : IShapeVisitor
    {
        public void Visit(Dot dot) => Console.WriteLine($"This is instance of {nameof(Dot)} class.");

        public void Visit(Rectangle rectangle) => Console.WriteLine($"This is instance of {nameof(Rectangle)} class.");

        public void Visit(Triangle triangle) => Console.WriteLine($"This is instance of {nameof(Triangle)} class.");
    }
}