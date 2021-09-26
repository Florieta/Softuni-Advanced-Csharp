using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parantheses = Console.ReadLine();
            Stack<char> paranthesesStack = new Stack<char>();
            bool isBalanced = true;
            Dictionary<char, char> pairs = new Dictionary<char, char>();
            pairs.Add('(', ')');
            pairs.Add('{', '}');
            pairs.Add('[', ']');


            foreach (var paranthesis in parantheses)
            {
                if (parantheses.Length % 2 != 0 || parantheses.Length == 0)
                {
                    isBalanced = false;
                    break;
                }
                if (pairs.ContainsKey(paranthesis))
                {
                    paranthesesStack.Push(paranthesis);
                }
                else
                {
                    char openParantesis = paranthesesStack.Pop();
                    if (pairs[openParantesis] != paranthesis)
                    {
                        isBalanced = false;
                    }
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
