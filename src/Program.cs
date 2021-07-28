using System;
using Trie;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new SimpleTrie();
            trie.Insert("hello");
            trie.Insert("hi");
            Console.WriteLine(trie.Find("hi").value);
        }
    }
}
