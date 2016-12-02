using Microsoft.VisualStudio.TestTools.UnitTesting;
using VoronoiUI;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        [TestMethod]
        public void Empty()
        {
            var q = new PriorityQueue<int>((x,y)=>-1);
            Assert.IsTrue(q.IsEmpty);

            q.Enqueue(42);

            Assert.IsFalse(q.IsEmpty);
        }

        [TestMethod]
        public void DequeuesByPriority()
        {
            var q = new PriorityQueue<int>((x,y)=>x - y);

            q.Enqueue(1);
            q.Enqueue(5);

            Assert.AreEqual(5,q.Dequeue());
            Assert.AreEqual(1,q.Dequeue());
        }

        [TestMethod]
        public void PeekHasNoSideeffects()
        {
            var q = new PriorityQueue<int>((x, y) => x - y);
            q.Enqueue(5);

            q.Peek();
            Assert.IsFalse(q.IsEmpty);
        }

        [TestMethod]
        public void DequeueHasSideeffects()
        {
            var q = new PriorityQueue<int>((x, y) => x - y);
            q.Enqueue(5);

            q.Dequeue();
            Assert.IsTrue(q.IsEmpty);
        }

        [TestMethod]
        public void SourceHasPriority()
        {
            var q = new PriorityQueue<int>(new int[] {1,3,2}, (x,y)=> x - y);

            Assert.IsFalse(q.IsEmpty);

            Assert.AreEqual(3,q.Dequeue());
            Assert.AreEqual(2,q.Dequeue());
            Assert.AreEqual(1,q.Dequeue());
        }
    }
}