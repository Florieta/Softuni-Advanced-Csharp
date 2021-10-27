using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //string name = "Pesho";
            //int age = 20;
            //Person pesho = new Person()
            //{
            //    Name = name,
            //    Age = age,
            //};

            //Console.WriteLine($"{pesho.Name} - {pesho.Age}");
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
