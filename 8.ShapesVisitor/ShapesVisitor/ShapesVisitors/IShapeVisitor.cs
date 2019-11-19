using ShapesVisitor.Shapes;

namespace ShapesVisitor.ShapesVisitors
{
    public interface IShapeVisitor
    {
        void Visit(Dot dot);
        void Visit(Rectangle rectangle);
        void Visit(Triangle triangle);
    }
}