using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronoiUI
{
    public class Beachline : BinarySearchTree<Event>
    {
        private readonly PriorityQueue<Event> _eventQueue;

        public Beachline(PriorityQueue<Event> eventQueue) :
            base((e1, e2) => (int)(e1.Y - e2.Y)) //the Beachlines Arcs has to be sorted normal to the Swapline
        {
            _eventQueue = eventQueue;
        }

        public void Add(Event parabola)
        {
            
        }

        public void Remove(Event parabola)
        {
            
        }

        private void CheckCircleEvent(Event parabola)
        {
            
        }
    }
}
