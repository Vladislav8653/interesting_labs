using Figures.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Factory
{
    public interface IShapeFactory
    {
        IDrawable CreateShape(Pen pen, Point startPoint, Point finishPoint);
    }
}
