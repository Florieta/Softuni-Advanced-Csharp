using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine();
                list.Add(input);
            }

            var box = new Box<string>(list);
            var elementToCompare = Console.ReadLine();
        }
    }
}
