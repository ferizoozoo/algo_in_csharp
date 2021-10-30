using BinaryMaxHeap;

namespace PriorityQueue
{
    public class PriorityQueue
    {
        private Heap _heap;

        public bool IsEmpty => _heap.Length == 0;

        public void InsertWithPriority(Node node)
        {
            _heap.Insert(node);
        }

        public Node PullHighestPriorityElement()
        {
            return _heap.Extract();
        }
    }
}
