using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            Queue<int> input = new Queue<int>(numbers);

            while (!input.All(i => i % 2 == 0))
            {
                if (input.Peek() % 2 == 0)
                {
                    input.Enqueue(input.Dequeue());
                }
                else
                {
                    input.Dequeue();
                }
            }

            Console.WriteLine(string.Join(", ", input.Reverse()));
        }
    }
}
