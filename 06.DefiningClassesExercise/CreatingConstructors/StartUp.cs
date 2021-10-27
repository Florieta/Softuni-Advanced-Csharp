using System;

namespace DefiningClasses

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new Person()
            {
                Name = "Peter",
                Age = 20
            };
            Person george = new Person();
            george.Name = "George";
            george.Age = 18;
            Person sam = new Person()
            {
                Name = "Sam",
                Age = 43
            };
        }
    }
}
