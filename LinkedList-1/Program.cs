using System.Collections.Generic;

namespace LinkedList_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.PrintList(); 
            // Output: Head -> 5 -> 10 -> 20 -> 30 -> Null

            list.Remove(10);
            list.PrintList(); 
            // Output: Head -> 5 -> 20 -> 30 -> Null
        }
    }
}
