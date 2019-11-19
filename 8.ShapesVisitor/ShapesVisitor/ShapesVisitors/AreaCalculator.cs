using System;
using System.Drawing;
using ShapesVisitor.Shapes;
using Rectangle = ShapesVisitor.Shapes.Rectangle;

namespace ShapesVisitor.ShapesVisitors
{
    public class AreaCalculator : IShapeVisitor
    {
        public void Visit(Dot dot) => Console.WriteLine($"{nameof(Dot)} area: {0}");

        public void Visit(Rectangle rectangle) =>
            Console.WriteLine($"{nameof(Rectangle)} area: {rectangle.Size.Height * rectangle.Size.Width}");

        public void Visit(Triangle triangle)
        {
            var firstSide = GetDistanceBetween(triangle.FirstPoint, triangle.SecondPoint);
            var secondSide = GetDistanceBetween(triangle.SecondPoint, triangle.ThirdPoint);
            var thirdSide = GetDistanceBetween(triangle.ThirdPoint, triangle.FirstPoint);

            var halfOfSum = (firstSide + secondSide + thirdSide) / 2;

            var triangleArea = Math.Sqrt(halfOfSum * (halfOfSum - firstSide) *
                                         (halfOfSum - secondSide) *
                                         (halfOfSum - thirdSide));

            Console.WriteLine($"{nameof(Triangle)} area: {triangleArea}");

            static double GetDistanceBetween(PointF firstPoint, PointF secondPoint) =>
                Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
        }
    }
}