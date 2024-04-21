namespace Figures.Shapes
{
    public class Rectangle : Line
    {

        /* public void DrawRectangle(Graphics g, Point leftTopAngle, Point rightBottomAngle, Pen pen)
         {
             Line line = new Line();
             Point rightTopAngle = new Point(rightBottomAngle.X, leftTopAngle.Y);
             Point leftBottomAngle = new Point(leftTopAngle.X, rightBottomAngle.Y);
             DrawLine(g, leftTopAngle, rightTopAngle, pen);
             DrawLine(g, rightTopAngle, rightBottomAngle, pen);
             DrawLine(g, rightBottomAngle, leftBottomAngle, pen);
             DrawLine(g, leftBottomAngle, leftTopAngle, pen);
         }
         public void DrawRectangle(Graphics g, Point leftTopAngle, Point rightBottomAngle, int step, Pen pen)
         {
             Line line = new Line();
             Point rightTopAngle = new Point(rightBottomAngle.X - step, leftTopAngle.Y);
             Point leftBottomAngle = new Point(leftTopAngle.X + step, rightBottomAngle.Y);
             DrawLine(g, leftTopAngle, rightTopAngle, pen);
             DrawLine(g, rightTopAngle, rightBottomAngle, pen);
             DrawLine(g, rightBottomAngle, leftBottomAngle, pen);
             DrawLine(g, leftBottomAngle, leftTopAngle, pen);
         }*/
    }
}
