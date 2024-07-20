using System;
using LinkedListImplementation;

namespace MergeSortedLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two sorted linked lists
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            // Merge the lists
            LinkedList mergedList = list1.MergeSortedLists(list1, list2);

            // Display the merged list
            Console.WriteLine("Merged List: " + mergedList.ToString());
        }
    }
}
