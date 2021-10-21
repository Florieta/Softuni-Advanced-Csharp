using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int divisibleNumber = int.Parse(Console.ReadLine());
            Predicate<int> filter = numbers => numbers % divisibleNumber != 0;
            Action<int[]> printer = number => Console.WriteLine(string.Join(" ", number.Reverse().Where(x => filter(x))));
            printer(numbers);
        }
    }
}
