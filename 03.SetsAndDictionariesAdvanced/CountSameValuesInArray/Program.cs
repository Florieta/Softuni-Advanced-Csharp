using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsAndDictionariesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> counter = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (counter.ContainsKey(number) == false)
                {
                    counter.Add(number, 1);
                }
                else
                {
                    counter[number]++;
                }
            }

            foreach (var number in counter)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
