using Figures.Factory;
using Figures.Strategies;

namespace Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point start;
        const int OBJECT_SIZE = 100; // будет крутилка, измен€ющее это
        const int PEN_WIDTH = 15; // будет крутилка, измен€ющее это
        Pen pen; // будет крутилка, измен€ющее это
        Color color; // будет крутилка, измен€ющее это
        private IShapeFactory _curFactory;
        private IDrawingMethods _curStrategy;

        public enum AllShapes
        {
            Circle,
            Ellipes,
            Line,
            Parallelogram,
            Rectangle,
            Rhombus,
            Triangle
        }


        private void Canvas_Paint(object sender, PaintEventArgs e)
        {

            if (_curFactory != null && _curStrategy != null)
            {
                _curFactory = new ShapeCreator();
                //_curStrategy = new
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LineButton.Checked = false;
            RectangleButton.Checked = false;
            TriangleButton.Checked = false;
            RhombusButton.Checked = false;
            CircleButton.Checked = false;
            ParallelogramButton.Checked = false;
            EllipseButton.Checked = false;
            start = Point.Empty;
            color = Color.Black;
            pen = new Pen(color, PEN_WIDTH);
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            Canvas.Refresh();
        }

        private void Canvas_Click(object sender, EventArgs e)
        {

        }

        private void TriangleButton_CheckedChanged(object sender, EventArgs e)
        {
            _curFactory = new LineFactory();
            _curStrategy = new LineMethods();

        }

        private void LineButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RectangleButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RhombusButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CircleButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ParallelogramButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EllipseButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}