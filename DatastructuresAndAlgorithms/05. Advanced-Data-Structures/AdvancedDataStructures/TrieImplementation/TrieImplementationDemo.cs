namespace TrieImplementation
{
    using System;
    using System.IO;

    public class TrieImplementationDemo
    {
        /* 03. Write a program that finds a set of words (e.g. 1000 words) in a large text (e.g. 100 MB text file). Print how many times each word occurs in the text.
        Hint: you may find a C# trie in Internet.
        */
        public static void Main()
        {
            Trie trieStructure = new Trie();

            using (StreamReader inputFile = new StreamReader("../../fatFile.txt"))
            {
                string line = inputFile.ReadLine();

                while (line != null)
                {
                    InsertInTrie(trieStructure, line);
                    line = inputFile.ReadLine();
                }
            }
        }

        private static void InsertInTrie(Trie trieStructure, string text)
        {
            char[] separators = new char[] { ' ', ',', ';', '.' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                trieStructure.Insert(word);
            }
        }
    }
}