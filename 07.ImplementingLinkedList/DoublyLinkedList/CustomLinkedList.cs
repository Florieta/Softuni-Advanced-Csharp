using System.Collections.Generic;
using System.Linq;
using System;

namespace DoublyLinkedList
{
    /// <summary>
    /// Doubly Linked List
    /// </summary>
    public class CustomLinkedList
    {
        /// <summary>
        /// Count of elements
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// First element
        /// </summary>
        public Node Head { get; set; }
        /// <summary>
        /// Last element
        /// </summary>
        public Node Tail { get; set; }
        /// <summary>
        /// Create empty list
        /// </summary>
        public CustomLinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }
        /// <summary>
        /// create list with one element
        /// </summary>
        /// <param name="value">value of the element</param>
        public CustomLinkedList(int value)
            :this()
        {
            Head = Tail = new Node()
            {
                Value = value,
                Next = null,
                Previous = null
            };

            Count++;
        }
        /// <summary>
        /// Create a list which it is collection of elements
        /// </summary>
        /// <param name="list">elements to be added in the list</param>
        public CustomLinkedList(IEnumerable<int> list)
            :this (list.First())
        {
            bool isFirst = true;
            foreach (var item in list)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    Node newNode = new Node()
                    {
                        Value = item,
                        Previous = Tail,
                        Next = null
                    };
                    Tail.Next = newNode;
                    Tail = newNode;
                    Count++;
                }
            }
        }
        /// <summary>
        /// Add element at the beginning
        /// </summary>
        /// <param name="element">element to be added</param>
        public void AddFirst(int element)
        {
            Node newNode = new Node() { Value = element };

            if (Count == 0)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
            Count++;
        }
        /// <summary>
        /// Add element at the end
        /// </summary>
        /// <param name="element">element to be added</param>
        public void AddLast(int element)
        {
            Node newNode = new Node() { Value = element };

            if (Count == 0)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }
        /// <summary>
        /// Remove element at the beginning
        /// </summary>
        /// <returns></returns>
        public int RemoveFirst()
        {
            if (Count > 0)
            {
                int result = Head.Value;
                Node second = Head.Next;
                if (second == null)
                {
                    Tail = null;
                }
                else
                {
                    second.Previous = null;
                }
                
                Head = second;
                Count--;

                return result;
            }
            throw new IndexOutOfRangeException("Empty list");
        }
        /// <summary>
        /// Remove element at the end
        /// </summary>
        /// <returns></returns>
        public int RemoveLast()
        {
            if (Count > 0)
            {
                int result = Tail.Value;
                Node previous = Tail.Previous;
                if (previous == null)
                {
                    Head = null;
                }
                else
                {
                    previous.Next = null;
                }

                Tail = previous;
                Count--;

                return result;
            }
            throw new IndexOutOfRangeException("Empty list");
        }
        /// <summary>
        /// Goes through the collection and make some action
        /// </summary>
        /// <param name="action">action to be performed</param>
        public void Foreach(Action<int> action)
        {
            Node currentNode = Head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        /// <summary>
        /// Turn the list into array
        /// </summary>
        /// <returns>Returns the elements of the list</returns>
        public int[] ToArray()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("Empty list");
            }

            int[] result = new int[Count];
            int index = 0;
            Node currentNode = Head;

            while (currentNode != null)
            {
                result[index] = currentNode.Value;
                index++;
                currentNode = currentNode.Next;
            }

            return result;
        }

    }
    
}
