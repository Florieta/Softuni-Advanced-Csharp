using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var scale = new EqualityScale<int>(3, 3);
            Console.WriteLine(scale.AreEqual());
        }
    }
}
