using Figures.Shapes;
using static Figures.MainForm;

namespace Figures.Factory
{
    public class ShapeCreator: IShapeFactory
    {
        public IDrawable CreateShape(AllShapes shapes, params object[] args)
        {
            //only line
            if (args.Length != 2) 
            {
                throw new ArgumentException("Некорректное количество параметров для создания круга.");
            }
            Point startPoint = (Point)args[0];
            Point finishPoint = (Point)args[1];
            return new Line(startPoint, finishPoint);

        }
    }
}
