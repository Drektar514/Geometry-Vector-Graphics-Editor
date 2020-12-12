﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    interface IFigureFactory
    {
        bool Contains(PointF start, PointF end, PointF checkPoint, double accuracy);


        bool CheckInside(double x, double a, double b, double accuracy);


    }
}