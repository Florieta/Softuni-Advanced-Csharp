using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> guestsCapacity = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedFood = 0;

            while (guestsCapacity.Count > 0 && plates.Count > 0)
            {
                if (guestsCapacity.Peek() - plates.Peek() <= 0)
                {
                    wastedFood += Math.Abs(guestsCapacity.Peek() - plates.Peek());
                    guestsCapacity.Pop();
                }
                else
                {
                    guestsCapacity.Push(guestsCapacity.Pop() - plates.Peek());
                }
                plates.Pop();
            }

            if (guestsCapacity.Count > 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guestsCapacity)}");
            }
            else if (plates.Count > 0)
            {
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            }

            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
