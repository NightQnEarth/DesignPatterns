using System.Drawing;
using ShapesVisitor.ShapesVisitors;

namespace ShapesVisitor.Shapes
{
    public struct Rectangle : IShape
    {
        public Rectangle(PointF location, SizeF size)
        {
            Location = location;
            Size = size;
        }

        public PointF Location { get; }
        public SizeF Size { get; }

        public void AcceptVisitor(IShapeVisitor visitor) => visitor.Visit(this);
    }
}