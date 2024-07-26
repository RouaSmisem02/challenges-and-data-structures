using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(5);
            Console.WriteLine($"Popped: {stack.Pop()}");
            Console.WriteLine($"Peeked: {stack.Peek()}");
            Console.WriteLine($"Is Stack Empty: {stack.IsEmpty()}");

            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(5);
            Console.WriteLine($"Dequeued: {queue.Dequeue()}");
            Console.WriteLine($"Peeked: {queue.Peek()}");
            Console.WriteLine($"Is Queue Empty: {queue.IsEmpty()}");
        }
    }
}
