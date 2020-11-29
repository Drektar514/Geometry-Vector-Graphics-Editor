﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor
{
    public partial class Form1 : Form
    {
        Bitmap _btm;
        Graphics _graphics;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            _graphics.DrawEllipse(pen, rect);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _btm = new Bitmap(pictureBox1.Width, pictureBox1.Width);
            _graphics = Graphics.FromImage(_btm);
            pen = new Pen(Color.Black, 3);
        }
    }
}
