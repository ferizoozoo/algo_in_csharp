using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryMaxHeap
{
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
            var lastNode = _heap[this.Length - 1];
            _heap[0] = lastNode;
            _heap.RemoveAt(this.Length - 1);

            return extractedNode;
        }

        public void Delete(int key)
        {
            //Find the node
            (int nodeIndex, Node foundNode) = this.Search(key);

            //Swap found node with last node
            _heap[nodeIndex] = _heap[this.Length];
            _heap[this.Length - 1] = foundNode;

            //Delete swapped node (foundNode)
            _heap.RemoveAt(this.Length - 1);

            //Sift down the swapped node (lastNode before deletion)
            SiftDown(nodeIndex);
        }

        public (int, Node) Search(int key)
        {
            for (int index = 0; index < this.Length; index++)
            {
                var node = _heap[index];
                if (node.Key == key)
                    return (index, node);
            }

            return (-1, null);
        }
    }
}
