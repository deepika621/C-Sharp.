using System;
using System.Collections;

namespace StackDS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a stack Using Stack class
            Stack my_stack = new Stack();

            // Adding elements in the Stack Using Push 
            my_stack.Push("Grapes");
            my_stack.Push("Apple");
            my_stack.Push(100);
            my_stack.Push(null);
            my_stack.Push("Kiwi");
            my_stack.Push("Avacado");
            my_stack.Push("Mango");

            // Accessing the elements of my stack Stack Using foreach loop
            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("Total elements present in" +
                    " my stack: {0}", my_stack.Count);

            my_stack.Pop();

            // After Pop method
            Console.WriteLine("Total elements present in " +
                          "my stack: {0}", my_stack.Count);

            // Obtain the topmost element of my stack Using Peek method
            Console.WriteLine("Topmost element of my stack " +
                                  "is: {0}", my_stack.Peek());


            Console.WriteLine("Total elements present " +
                     "in my stack: {0}", my_stack.Count);

            // Remove all the element from the stack
            my_stack.Clear();

            // After Pop method
            Console.WriteLine("Total elements present in " +
                          "my stack: {0}", my_stack.Count);
        }
    }
}
