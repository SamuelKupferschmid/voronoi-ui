using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronoiUI
{
    public class BinarySearchTree<T>
    {
        private readonly Comparison<T> _comparison;

        public BinarySearchTree(Comparison<T> comparison)
        {
            _comparison = comparison;
        }

        protected Node<T> Root;

        public void Insert(T value)
        {
            
        }

        public void Delete(T value)
        {
            
        }

        public bool Contains(T value)
        {
            return false;
        }

        public class Node<T>
        {
            public readonly T Value;
            public Node<T> Left { get; set; } 
            public Node<T> Right { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }
    }
}
