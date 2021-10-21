using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Action<int[]> printer = number => Console.WriteLine(string.Join(" ", number));
            string commands = Console.ReadLine();

            while (commands != "end")
            {
                if (commands == "add")
                {
                    numbers = ForEach(numbers, number => ++number);
                }
                else if (commands == "multiply")
                {
                    numbers = ForEach(numbers, number => number * 2);
                }
                else if (commands == "subtract")
                {
                    numbers = ForEach(numbers, number => --number);
                }
                else if (commands == "print")
                {
                    printer(numbers);
                }
                commands = Console.ReadLine();

            }
        }

        public static int[] ForEach(int[] numbers, Func<int, int> func)
        => numbers.Select(number => func(number)).ToArray();
    }
}
