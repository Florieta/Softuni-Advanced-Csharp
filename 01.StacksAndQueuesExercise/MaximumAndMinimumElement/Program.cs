using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                int command = int.Parse(cmd[0]);
                if (command == 1)
                {
                    int number = int.Parse(cmd[1]);
                    stack.Push(number);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command == 4)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
