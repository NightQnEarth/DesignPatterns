using ShapesVisitor.ShapesVisitors;

namespace ShapesVisitor.Shapes
{
    public interface IShape
    {
        void AcceptVisitor(IShapeVisitor visitor);
    }
}