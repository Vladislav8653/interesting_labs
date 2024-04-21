using Figures.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    internal class LineFactory: IShapeFactory
    {
        public IDrawable CreateShape (Pen pen, Point startPoint, Point finishPoint)
        {
            return new Line(startPoint, finishPoint);
        }
    }
}
