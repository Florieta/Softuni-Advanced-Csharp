using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputHats = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputScarfs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> hats = new Stack<int>(inputHats);
            Queue<int> scarfs = new Queue<int>(inputScarfs);

            List<int> sets = new List<int>();

            while (scarfs.Count > 0 && hats.Count > 0)
            {
                if (hats.Peek() == scarfs.Peek())
                {
                    scarfs.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }
                else if (scarfs.Peek() > hats.Peek())
                {
                    hats.Pop();
                }
                else if (hats.Peek() > scarfs.Peek())
                {
                    sets.Add(hats.Pop() + scarfs.Dequeue());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
    