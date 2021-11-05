using DoublyLinkedList;
using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomLinkedList myList = new CustomLinkedList(new int[] { 5, 7, 12 });

            myList.Foreach(Console.WriteLine);

            myList.AddFirst(100);

            Console.WriteLine($"Removed item: {myList.RemoveFirst()}");

            myList.Foreach(Console.WriteLine);

            myList.AddLast(2);

            myList.Foreach(Console.WriteLine);

            Console.WriteLine($"Removed item: {myList.RemoveLast()}");

            int[] arr = myList.ToArray();
            myList.Foreach(Console.WriteLine);
        }
    }
}
