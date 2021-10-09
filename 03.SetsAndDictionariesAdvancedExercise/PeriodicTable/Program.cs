using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            FillSet(elements, n);
            Console.WriteLine(string.Join(" ", elements));
        }

        private static SortedSet<string> FillSet(SortedSet<string> elements, int number)
        {
            
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int k = 0; k < input.Length; k++)
                {
                    elements.Add(input[k]);
                }
            }
            
            return elements;
        }
    }
}
