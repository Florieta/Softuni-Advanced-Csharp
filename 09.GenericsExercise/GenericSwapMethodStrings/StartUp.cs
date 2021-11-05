using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            var box = new Box<string>(list);
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(list, indexes[0], indexes[1]);
            Console.WriteLine(box);
        }
    }
}
