using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountingWordsFromFile
{
    public class CountingWordsFromFile
    {
        //Write a program that counts how many times each word from given text file words.txt appears in it. 
        //The character casing differences should be ignored. The result words should be ordered by their number of occurrences in the text.
        //Example:
        //"This is the TEXT. Text, text, text - THIS TEXT! Is this the text?"
        //is => 2
        //the => 2
        //this => 3
        //text => 6

        public static void Main()
        {
            IDictionary<string, int> wordsCounts = new Dictionary<string, int>();
            string path = "../../words.txt";
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                string line = reader.ReadLine();
                char[] separators = new char[] { ' ', ',', '.', '-', '!', '?' };
                var words = line.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    if (!wordsCounts.ContainsKey(word))
                    {
                        wordsCounts[word] = 1;
                    }
                    else
                    {
                        wordsCounts[word]++;
                    }
                }

                var sortedWords = wordsCounts.OrderBy(w => w.Value);

                foreach (var kVpair in sortedWords)
                {
                    Console.WriteLine(kVpair.Key + " => " + kVpair.Value);
                }
            }
        }
    }
}
