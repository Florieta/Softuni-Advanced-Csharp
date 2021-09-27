using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRotations = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < numberRotations; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "1")
                {
                    stack.Push(sb.ToString());
                    string strToAppend = command[1];
                    sb.Append(strToAppend);
                }
                else if (command[0] == "2")
                {
                    stack.Push(sb.ToString());
                    int countChars = int.Parse(command[1]);
                    sb.Remove(sb.Length - countChars, countChars);
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(sb[index - 1]);
                }
                else if (command[0] == "4")
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(stack.Pop());
                    }
                    else
                    {
                        sb.Replace(sb.ToString(), stack.Pop());
                    }
                }
            }
        }
    }
}
