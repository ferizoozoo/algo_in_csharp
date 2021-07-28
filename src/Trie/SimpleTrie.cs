using System;

namespace Trie
{
    public class SimpleTrie
    {
        private readonly Node _root;
        public Node Root => _root;

        public SimpleTrie()
        {
            _root = new Node();
        }

        public void Insert(string value)
        {
            var node = _root;

            foreach (var character in value)
            {
                if (!node.children.ContainsKey(character))
                {
                    node.children[character] = new Node();
                }
                node = node.children[character];
            }
            
            node.value = value;
        }

        public Node Find(string key)
        {
            var node = _root;

            foreach (var character in key)
            {
                if (node.children.ContainsKey(character))
                {
                    node = node.children[character];
                }
            }

            return node != _root ? node : null;
        }
    }
}
