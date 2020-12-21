﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class PictureBoxMouseDownRotate: IMouseHandler
    {
       public PictureBoxMouseDownRotate(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public object Sender { get; set; }
        public EventArgs E { get; set; }
        public Canvas Canvas { get; set; }
        private IFigureFactory curFigureFactory;
        public void HandleEvent()
        {
            if (Canvas != null)
            {
                MouseEventArgs eMouse = (MouseEventArgs)E;
                Canvas.PrevPoint = new PointF(eMouse.X, eMouse.Y);
                foreach (Figure figure in Canvas.Figures)
                {
                    if (figure.Points !=null&& figure.IsSelected(Canvas.PrevPoint, 50))
                    {
                        Canvas.CurFigure = figure;
                        Canvas.Figures.Remove(Canvas.CurFigure);
                        Canvas.DrawAll();
                        break;
                    }
                }
            }
        }
    }
}
