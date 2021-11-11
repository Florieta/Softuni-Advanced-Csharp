using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            //int wavesOfOrcs = int.Parse(Console.ReadLine());

            //Queue<int> platesOfTheAragornsDefence = new Queue<int>(Console.ReadLine()
            //    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse).ToArray());

            //Stack<int> warriorOrcsLeft = new Stack<int>();
            //bool isTheDefenceOfGondorDestroyed = false;

            //for (int i = 1; i <= wavesOfOrcs; i++)
            //{
            //    Stack<int> newWaveOrcs = new Stack<int>(Console.ReadLine()
            //        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            //        .Select(int.Parse).ToArray());

            //    if (i % 3 == 0)
            //    {
            //        int additionalPlate = int.Parse(Console.ReadLine());
            //        platesOfTheAragornsDefence.Enqueue(additionalPlate);
            //    }

            //    while (newWaveOrcs.Count != 0 && platesOfTheAragornsDefence.Count != 0)
            //    {
            //        if (newWaveOrcs.Peek() > platesOfTheAragornsDefence.Peek())
            //        {
            //            newWaveOrcs.Push(newWaveOrcs.Pop() - platesOfTheAragornsDefence.Dequeue());
            //        }
            //        else if (platesOfTheAragornsDefence.Peek() > newWaveOrcs.Peek())
            //        {
            //            Queue<int> updatedPlatesOfTheAragornsDefence = new Queue<int>();

            //            updatedPlatesOfTheAragornsDefence.Enqueue(platesOfTheAragornsDefence.Dequeue() - newWaveOrcs.Pop());

            //            for (int j = 0; j < platesOfTheAragornsDefence.Count; j++)
            //            {
            //                updatedPlatesOfTheAragornsDefence.Enqueue(platesOfTheAragornsDefence.ElementAt(j));
            //            }

            //            platesOfTheAragornsDefence = updatedPlatesOfTheAragornsDefence;
            //        }
            //        else
            //        {
            //            platesOfTheAragornsDefence.Dequeue();
            //            newWaveOrcs.Pop();
            //        }

            //        if (platesOfTheAragornsDefence.Count == 0)
            //        {
            //            isTheDefenceOfGondorDestroyed = true;
            //            warriorOrcsLeft = newWaveOrcs;
            //            break;
            //        }
            //    }
            //}

            //if (isTheDefenceOfGondorDestroyed)
            //{
            //    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            //    Console.WriteLine($"Orcs left: {string.Join(", ", warriorOrcsLeft)}");
            //}
            //else
            //{
            //    Console.WriteLine("The people successfully repulsed the orc's attack.");
            //    Console.WriteLine($"Plates left: {string.Join(", ", platesOfTheAragornsDefence)}");
            //}

            int waves = int.Parse(Console.ReadLine());
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());
            Stack<int> orcs = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
                if (i % 3 == 0)
                {
                    int plate = int.Parse(Console.ReadLine());
                    plates.Push(plate);
                }

                while (plates.Count > 0 && orcs.Count > 0)
                {
                    if (plates.Peek() > orcs.Peek())
                    {
                        plates.Push(plates.Pop() - orcs.Pop());
                    }
                    else if (plates.Peek() < orcs.Peek())
                    {
                        orcs.Push(orcs.Pop() - plates.Pop());
                    }
                    else
                    {
                        plates.Pop();
                        orcs.Pop();
                    }
                }

                if (plates.Count == 0)
                {
                    break;
                }
            }

            if (orcs.Count > 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}
