namespace Figures.Shapes
{
    public class Line : IDrawable
    {
        public Point StartPoint { get; }
        public Point FinishPoint { get; }

        public Line (Point startPoint, Point finishPoint)
        {
            StartPoint = startPoint;
            FinishPoint = finishPoint;
        }

        public Point GetStartPoint ()
        {
            return StartPoint;
        }
        public Point GetFinishPoint()
        {
            return FinishPoint;
        }

    }
}
