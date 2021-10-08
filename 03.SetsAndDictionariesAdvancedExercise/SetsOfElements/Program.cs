using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            FillSets(first, lenghts[0]);
            FillSets(second, lenghts[1]);
            CheckSets(first, second);

        }

        static void CheckSets(HashSet<int> first, HashSet<int> second)
        {
            List<int> nums = new List<int>();
            foreach (var number in first)
            {
                if(second.Contains(number))
                {
                    nums.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        static HashSet<int> FillSets(HashSet<int> set, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }

            return set;
        }
    }
}
