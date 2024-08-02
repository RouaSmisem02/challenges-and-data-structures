using System;

namespace ReverseStackUsingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack); // Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1
            stack.ReverseStack();
            Console.WriteLine(stack); // Stack: Top -> 1 -> 2 -> 3 -> 4 -> 5

            stack.Push(6);
            stack.Push(7);
            Console.WriteLine(stack); // Stack: Top -> 7 -> 6 -> 1 -> 2 -> 3 -> 4 -> 5
            stack.ReverseStack();
            Console.WriteLine(stack); // Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1 -> 6 -> 7
        }
    }
}
