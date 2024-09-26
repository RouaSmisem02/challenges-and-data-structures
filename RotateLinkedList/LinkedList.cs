using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLinkedList
{
    public class LinkedList
    {
        public Node Head;

        // Adds a new node to the end of the list
        public void Append(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Displays the list
        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }

        // Rotates the list to the left by k places
        public void RotateLeft(int k)
        {
            if (Head == null || k == 0)
                return;

            // Calculate the length of the list
            Node current = Head;
            int length = 1;  // start from 1 to include the head
            while (current.Next != null)
            {
                current = current.Next;
                length++;
            }

            // Connect the last node to the head to make it circular
            current.Next = Head;

            // k can be greater than the list length, reduce it
            k = k % length;

            // Traverse to the (length - k)th node
            int stepsToNewHead = length - k;
            Node newTail = Head;
            for (int i = 1; i < stepsToNewHead; i++)
            {
                newTail = newTail.Next;
            }

            // The new head is the next node after the new tail
            Head = newTail.Next;

            // Break the circular connection
            newTail.Next = null;
        }
    }
}
