using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string querry = Console.ReadLine();

            Predicate<int> predicate = querry == "odd"
                ? new Predicate<int>((number) => number % 2 != 0)
                : new Predicate<int>((number) => number % 2 == 0);

            var result = new List<int>();

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
