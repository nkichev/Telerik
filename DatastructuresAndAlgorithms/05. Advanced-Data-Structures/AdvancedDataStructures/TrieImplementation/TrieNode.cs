namespace TrieImplementation
{
    using System;
    using System.Collections.Generic;

    public class TrieNode
    {
        public TrieNode(char character)
        {
            this.ChildNode = new Dictionary<char, TrieNode>();
            this.IsLast = false;
            this.Letter = character;
        }

        public char Letter { get; private set; }

        public bool IsLast { get; set; }

        public Dictionary<char, TrieNode> ChildNode { get; set; }

        public TrieNode GetChildNode(char character)
        {
            if (this.ChildNode != null)
            {
                if (this.ChildNode.ContainsKey(character))
                {
                    return this.ChildNode[character];
                }
            }

            return null;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            return this.Equals(obj);
        }

        public bool Equals(TrieNode obj)
        {
            if (obj != null &&
                obj.Letter == this.Letter)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int hash = 11;
            hash = (hash * 6) + this.Letter.GetHashCode();
            return hash;
        }
    }
}