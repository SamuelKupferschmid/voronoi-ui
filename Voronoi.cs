using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronoiUI
{
    public class Voronoi
    {
        public Func<Point, Point, double> GetDistance { get; private set; }
          
        public Voronoi(Geometry geometry)
        {
            if (geometry == Geometry.Euclidean)
                GetDistance = GetEuclideanDist;
            else
                GetDistance = GetManhattanDist;
        }

        public IEnumerable<Edge> CalcEdges(IEnumerable<Point> points)
        {
            yield break;
        } 


        public static double GetEuclideanDist(Point p1, Point p2)
            => Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

        public static double GetManhattanDist(Point p1, Point p2)
            => Math.Abs(p2.X - p1.X) + Math.Abs(p2.Y - p1.Y);
    }

    public enum Geometry
    {
        Manhattan,
        Euclidean
    }
}
