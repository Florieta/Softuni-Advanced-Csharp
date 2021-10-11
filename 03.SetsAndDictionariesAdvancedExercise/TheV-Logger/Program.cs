using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> vloggers = new Dictionary<string, List<string>>();
            Dictionary<string, int[]> userNumberOfFollows = new Dictionary<string, int[]>();
            string inputLines = Console.ReadLine();

            while (inputLines?.ToLower() != "statistics")
            {
                string[] tokens = inputLines.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string command = tokens[1];
                if (command.ToLower() == "joined")
                {
                    if (!vloggers.ContainsKey(username))
                    {
                        vloggers[username] = new List<string>();
                        userNumberOfFollows[username] = new int[2];

                    }
                }
                else if (command.ToLower() == "followed")
                {
                    string userToFollow = tokens[2];
                    if (vloggers.ContainsKey(username) && vloggers.ContainsKey(userToFollow))
                    {
                        if (!vloggers[userToFollow].Contains(username) && username != userToFollow)
                        {
                            vloggers[userToFollow].Add(username);
                            userNumberOfFollows[userToFollow][0]++;
                            userNumberOfFollows[username][1]++;
                        }
                    }
                }
                    inputLines = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            Dictionary<string, int[]> orderUsersAndFollowers = userNumberOfFollows
                .OrderByDescending(u => u.Value[0])
                .ThenBy(u => u.Value[1])
                .ToDictionary(x => x.Key, x => x.Value);

            int count = 1;
            string userToRemove = string.Empty;
            foreach (var kvp  in orderUsersAndFollowers)
            {
                userToRemove = kvp.Key;
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                count++;
                if (vloggers[kvp.Key].Count > 0)
                {
                    foreach (string follower in vloggers[kvp.Key].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                break;
            }

            orderUsersAndFollowers.Remove(userToRemove);
            foreach (var kvp in orderUsersAndFollowers)
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[0]} followers, {kvp.Value[1]} following");
                count++;
            }
        }
    }
}
