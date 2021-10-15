using System;
using System.IO;
using System.Text;
using System.Linq;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charToReplace = new char[] { '-', ',', '.', '!', '?' };

            using StreamReader reader = new StreamReader("text.txt");
            int count = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }

                if (count % 2 == 0)
                {
                   line = ReplaceAll(charToReplace, '@', line);
                    line = Reverse(line);
                    Console.WriteLine(line);
                }
                count++;
            }

        }

        static string Reverse(string line)
        {
            StringBuilder sb = new StringBuilder();
            string[] word = line.Split().ToArray();

            for (int i = 0; i < word.Length; i++)
            {
                sb.Append(word[word.Length - i - 1]);
                sb.Append(' ');
            }
            return sb.ToString().ToString().TrimEnd();
        }

        static string ReplaceAll(char[] charToReplace, char v, string line)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (charToReplace.Contains(currentSymbol))
                {
                    sb.Append('@');
                }
                else
                {
                    sb.Append(currentSymbol);
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
