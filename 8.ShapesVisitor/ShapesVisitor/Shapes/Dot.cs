using System.Drawing;
using ShapesVisitor.ShapesVisitors;

namespace ShapesVisitor.Shapes
{
    public struct Dot : IShape
    {
        public Dot(PointF location) => Location = location;

        public PointF Location { get; }

        public void AcceptVisitor(IShapeVisitor visitor) => visitor.Visit(this);
    }
}