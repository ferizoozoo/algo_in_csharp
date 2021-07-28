using System.Collections.Generic;
using System;

namespace Trie
{
    public class Node
    {
        public string value;
        public Dictionary<char, Node> children;

        public Node(string value = "")
        {
            this.value = value;
            this.children = new Dictionary<char, Node>();
        }
    }
}