using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            bool partyStarted = false;
            HashSet<string> VIPguests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "PARTY")
                {
                    partyStarted = true;
                    
                    continue;
                }

                if(partyStarted)
                {
                    if (IsVip(command))
                    {
                        VIPguests.Remove(command);
                    }
                    else
                    {
                        regularGuests.Remove(command);
                    }
                }
                else
                {
                    if (IsVip(command))
                    {
                        VIPguests.Add(command);
                    }
                    else
                    {
                        regularGuests.Add(command);
                    }
                }
                
            }
            Console.WriteLine(VIPguests.Count + regularGuests.Count);

            foreach (var person in VIPguests)
            {
                Console.WriteLine(person);
            }

            foreach (var person in regularGuests)
            {
                Console.WriteLine(person);
            }
        }



        private static bool IsVip (string number)
        {
            int num = 0;

            return int.TryParse(number.Substring(0, 1), out num);
        }
    }
}
