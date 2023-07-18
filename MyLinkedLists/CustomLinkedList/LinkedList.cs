using System;

namespace CustomLinkedList
{
    public class LinkedList<T>
    {
        //properties
        public Node<T> First {  get; private set; }
        public Node<T> Last { get; private set; }
        public int Count { get; private set; }
        public LinkedList() 
        {
            this.First = null;
            this.Last = null;

        }
    }
}
