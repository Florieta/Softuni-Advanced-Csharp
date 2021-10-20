using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Console.WriteLine(input.Min());

            Func<int[], int> minNumber = n => n.Min();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(minNumber(numbers));
        }
    }
}
