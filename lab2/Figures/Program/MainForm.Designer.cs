namespace Figures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Canvas = new PictureBox();
            LineButton = new RadioButton();
            RectangleButton = new RadioButton();
            TriangleButton = new RadioButton();
            RhombusButton = new RadioButton();
            CircleButton = new RadioButton();
            EllipseButton = new RadioButton();
            ParallelogramButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            SuspendLayout();
            // 
            // Canvas
            // 
            Canvas.BackColor = Color.Linen;
            Canvas.Location = new Point(2, 57);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(1272, 689);
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            Canvas.Click += Canvas_Click;
            Canvas.Paint += Canvas_Paint;
            Canvas.MouseClick += Canvas_MouseClick;
            // 
            // LineButton
            // 
            LineButton.AutoSize = true;
            LineButton.Location = new Point(12, 12);
            LineButton.Name = "LineButton";
            LineButton.Size = new Size(85, 24);
            LineButton.TabIndex = 3;
            LineButton.Text = "отрезок";
            LineButton.UseVisualStyleBackColor = true;
            LineButton.CheckedChanged += LineButton_CheckedChanged;
            // 
            // RectangleButton
            // 
            RectangleButton.AutoSize = true;
            RectangleButton.Location = new Point(103, 12);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(139, 24);
            RectangleButton.TabIndex = 4;
            RectangleButton.Text = "прямоугольник";
            RectangleButton.UseVisualStyleBackColor = true;
            RectangleButton.CheckedChanged += RectangleButton_CheckedChanged;
            // 
            // TriangleButton
            // 
            TriangleButton.AutoSize = true;
            TriangleButton.Checked = true;
            TriangleButton.Location = new Point(248, 12);
            TriangleButton.Name = "TriangleButton";
            TriangleButton.Size = new Size(116, 24);
            TriangleButton.TabIndex = 6;
            TriangleButton.TabStop = true;
            TriangleButton.Text = "треугольник";
            TriangleButton.UseVisualStyleBackColor = true;
            TriangleButton.CheckedChanged += TriangleButton_CheckedChanged;
            // 
            // RhombusButton
            // 
            RhombusButton.AutoSize = true;
            RhombusButton.Location = new Point(370, 12);
            RhombusButton.Name = "RhombusButton";
            RhombusButton.Size = new Size(68, 24);
            RhombusButton.TabIndex = 7;
            RhombusButton.Text = "ромб";
            RhombusButton.UseVisualStyleBackColor = true;
            RhombusButton.CheckedChanged += RhombusButton_CheckedChanged;
            // 
            // CircleButton
            // 
            CircleButton.AutoSize = true;
            CircleButton.Location = new Point(444, 12);
            CircleButton.Name = "CircleButton";
            CircleButton.Size = new Size(59, 24);
            CircleButton.TabIndex = 8;
            CircleButton.Text = "круг";
            CircleButton.UseVisualStyleBackColor = true;
            CircleButton.CheckedChanged += CircleButton_CheckedChanged;
            // 
            // EllipseButton
            // 
            EllipseButton.AutoSize = true;
            EllipseButton.Location = new Point(665, 12);
            EllipseButton.Name = "EllipseButton";
            EllipseButton.Size = new Size(78, 24);
            EllipseButton.TabIndex = 9;
            EllipseButton.Text = "эллипс";
            EllipseButton.UseVisualStyleBackColor = true;
            EllipseButton.CheckedChanged += EllipseButton_CheckedChanged;
            // 
            // ParallelogramButton
            // 
            ParallelogramButton.AutoSize = true;
            ParallelogramButton.Location = new Point(509, 12);
            ParallelogramButton.Name = "ParallelogramButton";
            ParallelogramButton.Size = new Size(150, 24);
            ParallelogramButton.TabIndex = 10;
            ParallelogramButton.Text = "параллелограмм";
            ParallelogramButton.UseVisualStyleBackColor = true;
            ParallelogramButton.CheckedChanged += ParallelogramButton_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1277, 749);
            Controls.Add(ParallelogramButton);
            Controls.Add(EllipseButton);
            Controls.Add(CircleButton);
            Controls.Add(RhombusButton);
            Controls.Add(TriangleButton);
            Controls.Add(RectangleButton);
            Controls.Add(LineButton);
            Controls.Add(Canvas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drawing";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Canvas;
        private RadioButton LineButton;
        private RadioButton RectangleButton;
        private RadioButton TriangleButton;
        private RadioButton RhombusButton;
        private RadioButton CircleButton;
        private RadioButton EllipseButton;
        private RadioButton ParallelogramButton;
    }
}