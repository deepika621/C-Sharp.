using System;

namespace Queue_Implementation
{
    class Queue
    {
        static readonly int MAX = 1000;
        private int front,rear;
        private int[] queue;
        public Queue()
        {
            queue = new int[MAX];
            front = 0;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return front == rear+1;
        }
        public bool IsFull()
        {
            return rear == MAX - 1;
        }
        internal void Enqueue(int data)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            queue[++rear] = data;
        }

        internal int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            int data = queue[front++];
            return data;
        }

        internal int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            int data= queue[front];
            return data;
        }

        internal void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Queue are :");
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(queue[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            // Adding elements in the Queue Using EnQueue
            myQueue.Enqueue(3);
            myQueue.Enqueue(5);
            myQueue.Enqueue(7);
            myQueue.Enqueue(9);
            //To Display the elements in Queue
            myQueue.PrintQueue();
            //Obtain the topmost element of Queue Using Peek method
            myQueue.Peek();
            Console.WriteLine("Item removed from Queue : {0}", myQueue.Dequeue());
            myQueue.PrintQueue();
        }
    }
}
