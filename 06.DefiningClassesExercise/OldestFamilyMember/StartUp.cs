using System;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                var cmdargs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdargs[0];
                int age = int.Parse(cmdargs[1]);
                var person = new Person(name, age);
                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }
}
