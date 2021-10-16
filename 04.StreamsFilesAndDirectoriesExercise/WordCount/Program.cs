using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordOccurunces = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("words.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string word = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray()[0].ToLower();
                    if (!wordOccurunces.ContainsKey(word))
                    {
                        wordOccurunces[word] = 0;
                    }

                    line = reader.ReadLine();
                }
            }
            using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
            {
                using (StreamReader reader = new StreamReader("text.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] words = line.Split().Select(x => x.TrimStart(new char[] { '-', ',', '.', '!', '?' }))
                            .Select(x => x.TrimEnd(new char[] { '-', ',', '.', '!', '?' }))
                            .Select(x => x.ToLower()).ToArray();
                        foreach (var word in words)
                        {
                            if (wordOccurunces.ContainsKey(word))
                            {
                                wordOccurunces[word]++;
                            }
                        }
                        line = reader.ReadLine();
                    }

                    foreach (var kvp in wordOccurunces.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }
    }
}
