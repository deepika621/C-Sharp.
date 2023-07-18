using System;
using System.Collections;

namespace Queue_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a queue Using Queue class
            Queue my_queue = new Queue();

            // Adding elements in Queue Using Enqueue() method
            my_queue.Enqueue("Rose");
            my_queue.Enqueue("Jasmine");
            my_queue.Enqueue(100);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("Hibiscus");

            // Accessing the elements of my_queue Queue Using foreach loop
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                    my_queue.Count);
            my_queue.Dequeue();

            // After Dequeue method
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
            // Obtain the topmost element of my_queue Using Peek method
            Console.WriteLine("Topmost element of my_queue is: {0}",
                                                   my_queue.Peek());

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Remove all the elements from the queue
            my_queue.Clear();

            // After Clear method
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
        }
    }
}
