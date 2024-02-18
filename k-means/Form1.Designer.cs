namespace miapr
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
            Button = new Button();
            label1 = new Label();
            class_input = new TextBox();
            images_input = new TextBox();
            label2 = new Label();
            pictureBox = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // Button
            // 
            Button.Location = new Point(1049, 3);
            Button.Name = "Button";
            Button.Size = new Size(201, 53);
            Button.TabIndex = 0;
            Button.Text = "Эмулировать";
            Button.UseVisualStyleBackColor = true;
            Button.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(247, 35);
            label1.TabIndex = 1;
            label1.Text = "Количество классов";
            // 
            // class_input
            // 
            class_input.HideSelection = false;
            class_input.Location = new Point(265, 21);
            class_input.MaxLength = 2;
            class_input.Name = "class_input";
            class_input.PlaceholderText = "от 2 до 20";
            class_input.Size = new Size(125, 27);
            class_input.TabIndex = 2;
            // 
            // images_input
            // 
            images_input.Location = new Point(880, 21);
            images_input.MaxLength = 6;
            images_input.Name = "images_input";
            images_input.PlaceholderText = "от 1000 до 100000";
            images_input.Size = new Size(149, 27);
            images_input.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(621, 12);
            label2.Name = "label2";
            label2.Size = new Size(253, 35);
            label2.TabIndex = 4;
            label2.Text = "Количество образов";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.MistyRose;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(12, 62);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1240, 600);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(426, 13);
            label3.Name = "label3";
            label3.Size = new Size(0, 35);
            label3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1262, 673);
            Controls.Add(label3);
            Controls.Add(pictureBox);
            Controls.Add(label2);
            Controls.Add(images_input);
            Controls.Add(class_input);
            Controls.Add(label1);
            Controls.Add(Button);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная работа 1, МиАПР, Арефин Владислав, гр.251004";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button;
        private Label label1;
        private TextBox class_input;
        private TextBox images_input;
        private Label label2;
        private PictureBox pictureBox;
        private Label label3;
    }
}