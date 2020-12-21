﻿namespace graphics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonRectangularTriangle = new System.Windows.Forms.Button();
            this.buttonIsoscalesTriangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonRegularPolygon = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonScale = new System.Windows.Forms.Button();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.buttonFilling = new System.Windows.Forms.Button();
            this.trackBarPointsAmount = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxClockwise = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointsAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1307, 7);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Очистить\r\n";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBrush
            // 
            this.buttonBrush.Location = new System.Drawing.Point(9, 35);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(99, 23);
            this.buttonBrush.TabIndex = 1;
            this.buttonBrush.Text = "Кисть";
            this.buttonBrush.UseVisualStyleBackColor = true;
            this.buttonBrush.Click += new System.EventHandler(this.buttonBrush_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(9, 63);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(99, 23);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(9, 102);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(99, 23);
            this.buttonSquare.TabIndex = 3;
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(9, 132);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(99, 23);
            this.buttonRectangle.TabIndex = 4;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(117, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1250, 648);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // buttonRectangularTriangle
            // 
            this.buttonRectangularTriangle.Location = new System.Drawing.Point(13, 213);
            this.buttonRectangularTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRectangularTriangle.Name = "buttonRectangularTriangle";
            this.buttonRectangularTriangle.Size = new System.Drawing.Size(99, 34);
            this.buttonRectangularTriangle.TabIndex = 7;
            this.buttonRectangularTriangle.Text = "Прямоугольный треугольник";
            this.buttonRectangularTriangle.UseVisualStyleBackColor = true;
            this.buttonRectangularTriangle.Click += new System.EventHandler(this.buttonRectangularTriangle_Click);
            // 
            // buttonIsoscalesTriangle
            // 
            this.buttonIsoscalesTriangle.Location = new System.Drawing.Point(12, 262);
            this.buttonIsoscalesTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIsoscalesTriangle.Name = "buttonIsoscalesTriangle";
            this.buttonIsoscalesTriangle.Size = new System.Drawing.Size(99, 35);
            this.buttonIsoscalesTriangle.TabIndex = 8;
            this.buttonIsoscalesTriangle.Text = "Равнобедренный треугольник";
            this.buttonIsoscalesTriangle.UseVisualStyleBackColor = true;
            this.buttonIsoscalesTriangle.Click += new System.EventHandler(this.buttonIsoscalesTriangle_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(12, 328);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(99, 23);
            this.buttonCircle.TabIndex = 9;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click_1);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(12, 364);
            this.buttonEllipse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(99, 23);
            this.buttonEllipse.TabIndex = 10;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(626, 7);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 17;
            this.buttonDraw.Text = "Рисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(841, 7);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 18;
            this.buttonMove.Text = "Двигать";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRegularPolygon
            // 
            this.buttonRegularPolygon.Location = new System.Drawing.Point(11, 421);
            this.buttonRegularPolygon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegularPolygon.Name = "buttonRegularPolygon";
            this.buttonRegularPolygon.Size = new System.Drawing.Size(99, 37);
            this.buttonRegularPolygon.TabIndex = 19;
            this.buttonRegularPolygon.Text = "Правильный многоугольник";
            this.buttonRegularPolygon.UseVisualStyleBackColor = true;
            this.buttonRegularPolygon.Click += new System.EventHandler(this.buttonRegularPolygon_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Black;
            this.buttonColor.Location = new System.Drawing.Point(6, 67);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(93, 29);
            this.buttonColor.TabIndex = 20;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.LargeChange = 1;
            this.trackBarWidth.Location = new System.Drawing.Point(4, 32);
            this.trackBarWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarWidth.Minimum = 1;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(99, 45);
            this.trackBarWidth.TabIndex = 21;
            this.trackBarWidth.Value = 1;
            this.trackBarWidth.Scroll += new System.EventHandler(this.trackBarWidth_Scroll);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(946, 7);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonRotate.TabIndex = 18;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(1052, 7);
            this.buttonScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(111, 23);
            this.buttonScale.TabIndex = 18;
            this.buttonScale.Text = "Масштабировать";
            this.buttonScale.UseVisualStyleBackColor = true;
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(545, 7);
            this.buttonBackColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(26, 23);
            this.buttonBackColor.TabIndex = 22;
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Цвет фона";
            // 
            // buttonFilling
            // 
            this.buttonFilling.Location = new System.Drawing.Point(732, 7);
            this.buttonFilling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFilling.Name = "buttonFilling";
            this.buttonFilling.Size = new System.Drawing.Size(75, 23);
            this.buttonFilling.TabIndex = 17;
            this.buttonFilling.Text = "Залить";
            this.buttonFilling.UseVisualStyleBackColor = true;
            // 
            // trackBarPointsAmount
            // 
            this.trackBarPointsAmount.Location = new System.Drawing.Point(7, 494);
            this.trackBarPointsAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarPointsAmount.Maximum = 15;
            this.trackBarPointsAmount.Minimum = 3;
            this.trackBarPointsAmount.Name = "trackBarPointsAmount";
            this.trackBarPointsAmount.Size = new System.Drawing.Size(104, 45);
            this.trackBarPointsAmount.TabIndex = 24;
            this.trackBarPointsAmount.Value = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Количество вершин";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonColor);
            this.groupBox1.Controls.Add(this.trackBarWidth);
            this.groupBox1.Location = new System.Drawing.Point(11, 557);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(104, 109);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры карандаша";
            // 
            // checkBoxClockwise
            // 
            this.checkBoxClockwise.AutoSize = true;
            this.checkBoxClockwise.Checked = true;
            this.checkBoxClockwise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClockwise.Location = new System.Drawing.Point(252, 15);
            this.checkBoxClockwise.Name = "checkBoxClockwise";
            this.checkBoxClockwise.Size = new System.Drawing.Size(163, 21);
            this.checkBoxClockwise.TabIndex = 27;
            this.checkBoxClockwise.Text = "По часовой стрелке";
            this.checkBoxClockwise.UseVisualStyleBackColor = true;
            this.checkBoxClockwise.Click += new System.EventHandler(this.checkBoxClockwise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1418, 700);
            this.Controls.Add(this.checkBoxClockwise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBackColor);
            this.Controls.Add(this.buttonRegularPolygon);
            this.Controls.Add(this.buttonScale);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonFilling);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonIsoscalesTriangle);
            this.Controls.Add(this.buttonRectangularTriangle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonBrush);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarPointsAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointsAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonRectangularTriangle;
        private System.Windows.Forms.Button buttonIsoscalesTriangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonRegularPolygon;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button buttonFilling;
        private System.Windows.Forms.TrackBar trackBarPointsAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxClockwise;
    }
}

