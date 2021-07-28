using System.Collections.Generic;
using System;

namespace Trie
{
    public class Node
    {
        public string value;
        public Dictionary<char, Node> children;
    }
}