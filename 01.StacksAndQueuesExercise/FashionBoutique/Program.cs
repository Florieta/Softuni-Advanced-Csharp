using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityOfTheRack = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(clothesInTheBox);
            int rackCounter = 1;
            int currentRackClothes = 0;

            while (clothes.Count > 0)
            {
                if (currentRackClothes + clothes.Peek() > capacityOfTheRack)
                {
                    currentRackClothes = 0;
                    rackCounter++;
                }
                currentRackClothes += clothes.Pop();
            }

            Console.WriteLine(rackCounter);
        }
    }
}
