namespace DoublyLinkedList
{
    /// <summary>
    /// Element from doubly linked list
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Value of element
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Previous element
        /// </summary>
        public Node Previous { get; set; }
        /// <summary>
        /// Next element
        /// </summary>
        public Node Next { get; set; }
    }
}
