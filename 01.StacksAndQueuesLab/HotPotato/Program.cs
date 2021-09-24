using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Queue<string> game = new Queue<string>(children);

            int n = int.Parse(Console.ReadLine());

            while (game.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    game.Enqueue(game.Dequeue());
                }
                Console.WriteLine($"Removed {game.Dequeue()}");
            }

            Console.WriteLine($"Last is {game.Dequeue()}");
        }
    }
}
