using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryMaxHeap
{
    //TODO: Test the whole class after implementing the Delete method
    public class Heap
    {
        private List<Node> _heap;
        public int Length => _heap.Count;

        public Heap()
        {
            _heap = new List<Node>();
        }

        public void Insert(Node node)
        {
            _heap.Add(node);
            SiftUp(Length);
        }

        private void SiftUp(int nodeIndex)
        {
            int currentIndex = nodeIndex;
            int parentIndex = (currentIndex - 2) / 2;
            var currentNode = _heap[currentIndex];
            var parentNode = _heap[parentIndex];

            if (parentIndex > 0 && currentNode.Key > parentNode.Key)
            {
                _heap[parentIndex] = currentNode;
                _heap[currentIndex] = parentNode;
                SiftUp(currentIndex);
            }
        }

        private void SiftDown(int nodeIndex)
        {
            int currentIndex = nodeIndex;
            var currentNode = _heap[currentIndex];

            int leftChildIndex = 2 * currentIndex + 1;
            int rightChildIndex = 2 * currentIndex + 2;
            
            Node leftChildNode = null;
            Node rightChildNode = null;

            if (leftChildIndex < this.Length && rightChildIndex < this.Length)
            {
                leftChildNode = _heap[leftChildIndex];
                rightChildNode = _heap[rightChildIndex];

                var largerKey = Math.Max(leftChildNode.Key, rightChildNode.Key);

                if (currentNode.Key < leftChildNode.Key && leftChildNode.Key == largerKey)
                {
                    _heap[leftChildIndex] = currentNode;
                    _heap[currentIndex] = leftChildNode;
                    SiftDown(leftChildIndex);
                }
                else if (currentNode.Key < rightChildNode.Key && rightChildNode.Key == largerKey)
                {
                    _heap[rightChildIndex] = currentNode;
                    _heap[currentIndex] = rightChildNode;
                    SiftDown(rightChildIndex);
                }
            }
        }

        public Node Extract()
        {
            var extractedNode = _heap[0];
            var lastNode = _heap[this.Length];
            _heap[0] = lastNode;
            _heap.RemoveAt(this.Length);

            return extractedNode;
        }

        //TODO: Implement the Delete method
        public void Delete(int key)
        {

        }

        public Node Search(int key)
        {
            foreach (var node in _heap)
            {
                if (node.Key == key)
                    return node;
            }

            return null;
        }
    }
}
