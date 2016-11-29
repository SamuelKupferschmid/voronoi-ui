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
    public class PriorityQueueTests
    {
        [TestMethod]
        public void ComparisonDuringEnqueue()
        {
            var called = false;
            var q = new PriorityQueue<double>((x, y) =>
            {
                called = true;
                return 0;
            });

            q.Enqueue(1);
            q.Enqueue(1);

            Assert.IsTrue(called);
        }
    }
}