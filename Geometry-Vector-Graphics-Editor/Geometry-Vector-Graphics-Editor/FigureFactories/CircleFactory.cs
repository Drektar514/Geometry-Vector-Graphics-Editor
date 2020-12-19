﻿using Geometry_Vector_Graphics_Editor.Actors;
using Geometry_Vector_Graphics_Editor.Updater;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class CircleFactory : IFigureFactory
    {
        public Figure CreateFigure()
        {
            CircleDrawer drawer = new CircleDrawer();
            CircleUpdater updater = new CircleUpdater();
            CicleMover mover = new CicleMover();
            RegularRotator rotator = new RegularRotator();
            RegularScaler scaler = new RegularScaler();
            Figure figure = new Figure(drawer, scaler, updater, mover, rotator);

            return figure;
        }
    }
}
