using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Stack<int> bombCasing = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            int sum = 0;
            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;


            while (bombEffects.Count > 0 && bombCasing.Count > 0)      
            {
                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    break;

                }
                sum = bombEffects.Peek() + bombCasing.Peek();

                if (sum == 40)
                {
                    daturaBombs++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else if (sum == 60)
                {
                    cherryBombs++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else if (sum == 120)
                {
                    smokeDecoyBombs++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else
                {
                    bombCasing.Push(bombCasing.Pop() - 5);
                }
            }

            if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }

            if (bombCasing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");



        }
    }
}
