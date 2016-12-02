using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronoiUI
{
    public struct Edge
    {
        public readonly double X1;
        public readonly double Y1;
        public readonly double X2;
        public readonly double Y2;

        public Edge(Event start, Event end)
        {
            X1 = start.X;
            Y1 = start.Y;

            X2 = end.X;
            Y2 = end.Y;
        }
    }
}
