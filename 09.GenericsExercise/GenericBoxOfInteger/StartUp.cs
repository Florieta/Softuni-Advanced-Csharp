using System;

namespace GenericBoxOfInteger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);
                Console.WriteLine(box);
            }
        }
    }
}
