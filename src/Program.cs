using System;
using BinaryMaxHeap;
//using Trie;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            // var trie = new SimpleTrie();
            // trie.Insert("hello");
            // trie.Insert("hi");
            // Console.WriteLine(trie.Find("hi").value);

            var heap = new Heap();
            heap.Insert(new BinaryMaxHeap.Node { Key = 3, Value = "hello" });
            heap.Insert(new BinaryMaxHeap.Node { Key = 13, Value = "hellosss" });
            heap.Insert(new BinaryMaxHeap.Node { Key = 31, Value = 1 });
            heap.Insert(new BinaryMaxHeap.Node { Key = 312, Value = new { X = 35, Y = 45 } });
            heap.Insert(new BinaryMaxHeap.Node { Key = 310, Value = 12.5 });
            heap.Insert(new BinaryMaxHeap.Node { Key = 540, Value = 12.5 });
            // Console.WriteLine(heap.Extract().Key);
            // Console.WriteLine(heap.Extract().Key);
            // Console.WriteLine(heap.Extract().Key);
            // Console.WriteLine(heap.Extract().Key);
            // Console.WriteLine(heap.Extract().Key);
            // Console.WriteLine(heap.Extract().Key);
            // var searchedNode = heap.Search(13);
            // Console.WriteLine($"{searchedNode.Item1} {searchedNode.Item2.Key}");
            // heap.Delete(540);
            // heap.Delete(312);
            // heap.Delete(13);
            // heap.Delete(3);
            // heap.Delete(310);
            // heap.Delete(31);

            Console.WriteLine(heap);
        }
    }
}
