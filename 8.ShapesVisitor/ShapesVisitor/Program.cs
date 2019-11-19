using System.Drawing;
using ShapesVisitor.Shapes;
using ShapesVisitor.ShapesVisitors;
using Rectangle = ShapesVisitor.Shapes.Rectangle;

namespace ShapesVisitor
{
    internal static class Program
    {
        private static readonly IShape[] shapes =
        {
            new Dot(PointF.Empty),
            new Triangle(PointF.Empty, PointF.Empty, PointF.Empty),
            new Rectangle(PointF.Empty, SizeF.Empty)
        };

        private static readonly IShapeVisitor[] visitors =
        {
            new ShapeDescriptor(),
            new Drawer(),
            new AreaCalculator()
        };

        private static void Main()
        {
            foreach (var shape in shapes)
                foreach (var visitor in visitors)
                    shape.AcceptVisitor(visitor);

            /*
             * Output:
             * 
             * This is instance of Dot class.
             * Dot{X=0, Y=0}
             * Dot area: 0
             * This is instance of Triangle class.
             * Triangle: {X=0, Y=0}-{X=0, Y=0}-{X=0, Y=0}
             * Triangle area: 0
             * This is instance of Rectangle class.
             * Rectangle: {X=0, Y=0}-{Width=0, Height=0}
             * Rectangle area: 0
             */
        }
    }
}