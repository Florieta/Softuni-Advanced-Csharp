using System;
using System.Collections.Generic;

namespace SetsAndDictionariesAdvancedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();
                usernames.Add(user);
            }

            foreach (var user in usernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
