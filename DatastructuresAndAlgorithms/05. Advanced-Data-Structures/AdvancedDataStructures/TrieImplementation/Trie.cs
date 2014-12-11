namespace TrieImplementation
{
    using System;

    public class Trie
    {
        private TrieNode rootNode;

        public Trie()
        {
            this.rootNode = new TrieNode(' ');
        }

        public void Insert(string word)
        {
            char[] wordCharacters = word.ToLower().ToCharArray();

            TrieNode current = this.rootNode;

            if (wordCharacters.Length == 0)
            {
                current.IsLast = true;
            }

            for (int i = 0; i < word.Length; i++)
            {
                TrieNode child = current.GetChildNode(wordCharacters[i]);
                if (child != null)
                {
                    current = child;
                }
                else
                {
                    current.ChildNode.Add(wordCharacters[i], new TrieNode(wordCharacters[i]));
                    current = current.GetChildNode(wordCharacters[i]);
                }

                if (i == wordCharacters.Length - 1)
                {
                    current.IsLast = true;
                }
            }
        }

        public bool Search(string word)
        {
            char[] wordCharacters = word.ToLower().ToCharArray();
            TrieNode current = this.rootNode;
            while (current != null)
            {
                for (int i = 0; i < wordCharacters.Length; i++)
                {
                    if (current.GetChildNode(wordCharacters[i]) == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.GetChildNode(wordCharacters[i]);
                    }
                }

                if (current.IsLast == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}