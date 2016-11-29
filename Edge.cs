using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronoiUI
{
    public struct Edge
    {
        public readonly Point Start;
        public readonly Point End;

        public Edge(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}
