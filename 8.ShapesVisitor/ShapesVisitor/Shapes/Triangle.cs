using System.Drawing;
using ShapesVisitor.ShapesVisitors;

namespace ShapesVisitor.Shapes
{
    public struct Triangle : IShape
    {
        public Triangle(PointF firstPoint, PointF secondPoint, PointF thirdPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;
        }

        public PointF FirstPoint { get; }
        public PointF SecondPoint { get; }
        public PointF ThirdPoint { get; }

        public void AcceptVisitor(IShapeVisitor visitor) => visitor.Visit(this);
    }
}