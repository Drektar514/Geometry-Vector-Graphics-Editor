﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
    [Serializable]
    public class SquareUpdater : IUpdater
    {
        public List<PointF>  Update(int pointsAmount, List<PointF> points)
        {
            return new List<PointF>(CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(points[0], points[1]));

        }
    }
}
