using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                int lettersCount = CountOfLetters(currentLine);
                int punctionalCount = CountOfPunctional(currentLine);
                lines[i] = $"Line {i + 1}: {currentLine}. ({lettersCount})({punctionalCount})";
            }
            File.WriteAllLines("../../../Output.txt", lines);
        }

        static int CountOfPunctional(string currentLine)
        {
            int count = 0;
            char[] punctionlArr = new char[] { '-', ',', '.', '!', '?' };
            for (int i = 0; i < currentLine.Length; i++)
            {
                char currChar = currentLine[i];
                if (char.IsPunctuation(currChar))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountOfLetters(string currentLine)
        {
            int count = 0;

            for (int i = 0; i < currentLine.Length; i++)
            {
                char currChar = currentLine[i];
                if (char.IsLetter(currChar))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
