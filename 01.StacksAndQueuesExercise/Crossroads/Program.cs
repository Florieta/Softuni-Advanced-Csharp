using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int secondToPassTheRoad = int.Parse(Console.ReadLine());
            Queue<string> carQueue = new Queue<string>();
            int totalCarPassed = 0;

            while (true)
            {
                string cmd = Console.ReadLine();
                int greenLight = greenLightSeconds;
                int secondsPass = secondToPassTheRoad;

                if (cmd == "END")
                {
                    Console.WriteLine($"Everyone is safe.{Environment.NewLine}" +
                    $"{totalCarPassed} total cars passed the crossroads.");
                    return;
                }

                if (cmd == "green")
                {
                    while (greenLight > 0 && carQueue.Count != 0)
                    {
                        string firstInQueue = carQueue.Dequeue();
                        greenLight -= firstInQueue.Length;
                        if (greenLight > 0)
                        {
                            totalCarPassed++;
                        }
                        else
                        {
                            secondsPass += greenLight;
                            if (secondsPass < 0)
                            {
                                Console.WriteLine($"A crash happened!{Environment.NewLine}" +
                                    $"{firstInQueue} was hit at {firstInQueue[firstInQueue.Length + secondsPass]}.");
                                return;
                            }
                            totalCarPassed++;
                        }
                        
                    }
                }
                else
                {
                    carQueue.Enqueue(cmd);
                }
            }
        }
    }
}
