using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Action<string[]> printNames = name =>
            {
                Predicate<string> filter = name => name.Length <= length;
                foreach (string currName in names.Where(name => filter(name)))
                {
                    Console.WriteLine(currName);
                }
            };

            printNames(names);
        }
    }
}
