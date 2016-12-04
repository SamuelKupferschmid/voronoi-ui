using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoronoiUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronoiUI.Tests
{
    [TestClass]
    public class VoronoiTests
    {
        [TestMethod]
        public void CalcEdgesSplit2PointsTest()
        {
            var v = new Voronoi(Geometry.Euclidean);

            var edges = v.CalcEdges(new []{new Event(1,1,EventType.Site), new Event(1,2,EventType.Site)});
            
            var edge = edges.Single();

            Assert.AreEqual(1.5, edge.Y1);

            Assert.AreEqual(edge.Y1,edge.Y2);
        }
    }
}