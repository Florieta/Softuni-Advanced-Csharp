using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> numbers = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] tokens = command.Split();
                
                switch (tokens[0])
                {
                    case "add":
                        numbers.Push(int.Parse(tokens[1]));
                        numbers.Push(int.Parse(tokens[2]));
                    break;
                    case "remove":
                        int count = int.Parse(tokens[1]);
                        if (numbers.Count >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Pop();
                            }
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
