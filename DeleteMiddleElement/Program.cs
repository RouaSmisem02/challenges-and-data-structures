using System;
using StackAndQueue.DeleteMiddleElement;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            Console.WriteLine("Initial Stack: " + stack);
            stack.DeleteMiddle();
            Console.WriteLine("After deleting middle element (odd-sized stack): " + stack);

            stack.Push(2);
            stack.Push(9);
            stack.Push(11);
            Console.WriteLine("Stack after adding more elements: " + stack);
            stack.DeleteMiddle();
            Console.WriteLine("After deleting middle element (even-sized stack): " + stack);
        }
    }
}
