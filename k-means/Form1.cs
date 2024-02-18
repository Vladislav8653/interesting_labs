namespace miapr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int classes = 0, images = 0;
        private List<(short, short, sbyte)> points;
        private List<(short, short)> centres;
        private List<Brush> randomBrushes;
        private const int length = 1233, height = 593;
        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (!int.TryParse(class_input.Text, out classes))
                {
                    MessageBox.Show("Проверьте поле ввода классов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    class_input.Text = "";
                    return;
                }
                if (!int.TryParse(images_input.Text, out images))
                {
                    MessageBox.Show("Проверьте поле ввода образов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    images_input.Text = "";
                    return;
                }
                if (classes < 2 || classes > 20)
                {
                    MessageBox.Show("Диапазон - [2, 20].", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    class_input.Text = "";
                    return;
                }
                if (images < 1000 || images > 100000)
                {
                    MessageBox.Show("Диапазон - [1000, 100000].", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    images_input.Text = "";
                    return;
                }
            }// считывание textbox'ов
            points = new List<(short, short, sbyte)>(images - classes);
            centres = new List<(short, short)>(classes);
            randomBrushes = GetBrushes(classes);
            CreateListOfPoints(ref points, length, height, images, classes);
            CreateListOfCentres(ref centres, length, height, classes);
            pictureBox.Refresh();
            Thread.Sleep(2000);
            label3.Text = "";
            DoKMeans(classes, images, length, ref points, ref centres);
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e) //1240 600
        {
            Graphics g = e.Graphics;
            const int height = 593;
            ClearBackground(height, e);
            DrawPosition(ref points, ref centres, randomBrushes, images, classes, e);
            Thread.Sleep(10);
        }
        private static void ClearBackground(int height, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.MistyRose, height + 10);
            Point startPoint = new Point(0, height / 2);
            Point endPoint = new Point(1240, height / 2);
            g.DrawLine(pen, startPoint, endPoint);
        }
        private static void DrawPosition(ref List<(short, short, sbyte)> points, ref List<(short, short)> centres,
            List<Brush> randomBrushes, int images, int classes, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < images - classes; i++)
            {
                Point p = new Point(points[i].Item1, points[i].Item2);
                g.FillEllipse(points[i].Item3 == -1 ? Brushes.Black : randomBrushes[points[i].Item3], p.X, p.Y, 5, 5);
            }
            for (int i = 0; i < classes; i++)
            {
                Point p = new Point(centres[i].Item1, centres[i].Item2);
                g.FillEllipse(randomBrushes[i], p.X, p.Y, 15, 15);
            }
        }
        private void CreateListOfPoints(ref List<(short, short, sbyte)> points, int length, int height, int images, int classes)
        {
            for (int i = 0; i < images - classes; i++)
            {
                int x = GetCoordinates(length, height).Item1;
                int y = GetCoordinates(length, height).Item2;
                points.Add(((short)x, (short)y, -1));
            }
        }
        private void CreateListOfCentres(ref List<(short, short)> centres, int length, int height, int classes)
        {
            for (int i = 0; i < classes; i++)
            {
                int x = GetCoordinates(length, height).Item1;
                int y = GetCoordinates(length, height).Item2;
                centres.Add(((short)x, (short)y));
            }
        }
        private (int, int) GetCoordinates(int length, int height)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, length);
            int y = rnd.Next(0, height);
            return (x, y);
        }
        private List<Brush> GetBrushes(int classes)
        {
            List<Brush> randomBrushes = new List<Brush>(classes);
            Random random = new Random();
            for (int i = 0; i < classes; i++)
            {
                byte red = (byte)random.Next(1, 256);
                byte green = (byte)random.Next(1, 256);
                byte blue = (byte)random.Next(1, 256);
                Brush br = new SolidBrush(Color.FromArgb(red, green, blue));
                randomBrushes.Add(br);
            }
            return randomBrushes;
        }
        private void DoKMeans(int classes, int images, int paintBoxLength,
            ref List<(short, short, sbyte)> points, ref List<(short, short)> centres)
        {
            List<(short, short)> memoryCentres = new List<(short, short)>(classes);
            double distance, min;
            (short, short) temp;
            int iteration = 0;
            do
            {
                memoryCentres.Clear();
                for (int i = 0; i < images - classes; i++)
                {
                    min = paintBoxLength;
                    for (int j = 0; j < classes; j++)
                    {
                        distance = Math.Sqrt(Math.Pow((points[i].Item1 - centres[j].Item1), 2) +
                            Math.Pow((points[i].Item2 - centres[j].Item2), 2));
                        if (min > distance)
                        {
                            min = distance;
                            temp = (points[i].Item1, points[i].Item2);
                            points[i] = (temp.Item1, temp.Item2, (sbyte)j);
                        }
                    }
                }
                int counter, sumOfX, sumOfY;
                for (int i = 0; i < classes; i++)
                {
                    counter = 0;
                    sumOfX = 0;
                    sumOfY = 0;
                    for (int j = 0; j < images - classes; j++)
                    {
                        if (points[j].Item3 == (sbyte)i)
                        {
                            sumOfX += points[j].Item1;
                            sumOfY += points[j].Item2;
                            counter++;
                        }
                    }
                    memoryCentres.Add((centres[i].Item1, centres[i].Item2));
                    centres[i] = ((short)(sumOfX / counter), (short)(sumOfY / counter));
                }
                label3.Text = "Итерация: " + (++iteration).ToString();
                pictureBox.Refresh();
                Application.DoEvents();
            } while (!memoryCentres.SequenceEqual(centres));
        }
    private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Q)
            {
                images_input.Text = "75000";
                class_input.Text = "18";
            }
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}