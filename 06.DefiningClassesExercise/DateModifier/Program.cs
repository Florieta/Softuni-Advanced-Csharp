using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] date1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            DateTime firstDate = new DateTime(int.Parse(date1[0]), int.Parse(date1[1].TrimStart('0')), int.Parse(date1[2].TrimStart('0')));
            string[] date2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            DateTime secondDate = new DateTime(int.Parse(date2[0]), int.Parse(date2[1].TrimStart('0')), int.Parse(date2[2].TrimStart('0')));
            Console.WriteLine(DateModifier.GetDifferenceOfTwoDates(firstDate, secondDate));
        }
    }
}
