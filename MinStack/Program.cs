using System;

namespace StackAndQueue.MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();

            minStack.Push(15); 
            minStack.Push(7);  
            minStack.Push(12); 
            minStack.Push(3);  

            minStack.PrintStack(); 

          
            int min = minStack.GetMin(); 
            Console.WriteLine($"Minimum element: {min}");

            int popped = minStack.Pop(); 
            Console.WriteLine($"Popped element: {popped}");
            minStack.PrintStack(); 
            
            min = minStack.GetMin();
            Console.WriteLine($"Minimum element after pop: {min}");

            
            int peeked = minStack.Top(); 
            Console.WriteLine($"Top element: {peeked}");

            minStack.Push(2);  
            minStack.PrintStack(); 

            min = minStack.GetMin(); 
            Console.WriteLine($"Minimum element after push: {min}");

            
            bool isEmpty = minStack.IsEmpty(); 
            Console.WriteLine($"Is stack empty? {isEmpty}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
