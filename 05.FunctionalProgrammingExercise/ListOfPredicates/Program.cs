using System;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (range <= 0)
            {
                return;
            }

            Func<int[], int, bool> filter = (alldividers, number) =>
            {
                bool divisible = true;

                for (int i = 0; i < alldividers.Length; i++)
                {
                    if (number % alldividers[i] != 0)
                    {
                        divisible = false;
                        break;
                    }
                }

                return divisible;
            };

            int[] divisibleNumbers = Enumerable.Range(1, range).Where(number => filter(dividers, number)).ToArray();

            Console.WriteLine(string.Join(" ", divisibleNumbers));
        }
    }
}
