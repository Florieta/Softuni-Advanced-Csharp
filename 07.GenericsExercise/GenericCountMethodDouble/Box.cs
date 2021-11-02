using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T> : IComparable<T> where T: IComparable<T>
    {
        public Box(T element)
        {
            Element = element;
        }

        public Box(List<T> elementsList)
        {
            Elements = elementsList;
        }

        public List<T> Elements { get; }
        public T Element { get; }

        public void Swap(List<T> elements, int indexOne, int indexTwo)
        {
            T firstEl = elements[indexOne];
            elements[indexOne] = elements[indexTwo];
            elements[indexTwo] = firstEl;
        }
        public override string ToString()
        {
            //return $"{typeof(T)}: {Element}";

            var sb = new StringBuilder();
            foreach (T element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");

            }
            return sb.ToString().TrimEnd();
        }

        public int CompareTo(T other) => Element.CompareTo(other);

        public int CountOfGreaterElements<T>(List<T> list, T readline) where T: IComparable
         => list.Count(word => word.CompareTo(readline) > 0);
       
    }
}
