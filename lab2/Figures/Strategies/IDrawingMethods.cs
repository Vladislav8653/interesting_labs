using Figures.Shapes;
using static Figures.Form;

namespace Figures.Strategies
{
    public interface IDrawingMethods // тут объявляются общие методы, которые будут у фигур
    {
        void Draw(AllShapes shapes, PaintEventArgs e, Pen pen);
    }
}
