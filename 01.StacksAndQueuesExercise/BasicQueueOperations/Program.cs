using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = commands[0];
            int s = commands[1];
            int x = commands[2];

            Queue<int> queue = new Queue<int>();
            EnqueueElements(queue, numbers, n);
            DequeueElements(queue, numbers, s);
            Checks(queue, x);
            

            
        }

        private static void Checks(Queue<int> queue, int command)
        {
            if (queue.Any())
            {
                if (queue.Contains(command))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        static Queue<int> DequeueElements(Queue<int> queue, int[] numbers, int command)
        {
            for (int i = 0; i < command; i++)
            {
                queue.Dequeue();
            }
            return queue;
        }

        static Queue<int> EnqueueElements(Queue<int> queue,int[] numbers, int command)
        {
            for (int i = 0; i < command; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            return queue;
        }
    }
}
