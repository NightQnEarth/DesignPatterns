using System;
using ShapesVisitor.Shapes;

namespace ShapesVisitor.ShapesVisitors
{
    public class Drawer : IShapeVisitor
    {
        public void Visit(Dot dot) => Console.WriteLine($"{nameof(Dot)}{dot.Location}");

        public void Visit(Rectangle rectangle) =>
            Console.WriteLine($@"{nameof(Rectangle)}: {rectangle.Location}-{rectangle.Size}");

        public void Visit(Triangle triangle) =>
            Console.WriteLine($@"{nameof(Triangle)}: {
                                      triangle.FirstPoint}-{
                                      triangle.SecondPoint}-{
                                      triangle.ThirdPoint}");
    }
}