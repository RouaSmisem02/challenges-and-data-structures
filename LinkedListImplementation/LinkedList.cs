using System;

namespace LinkedListImplementation
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Add(int value)
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

        public LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
        {
            Node dummy = new Node(0);
            Node tail = dummy;

            Node current1 = list1.Head;
            Node current2 = list2.Head;

            while (current1 != null && current2 != null)
            {
                if (current1.Value <= current2.Value)
                {
                    tail.Next = current1;
                    current1 = current1.Next;
                }
                else
                {
                    tail.Next = current2;
                    current2 = current2.Next;
                }
                tail = tail.Next;
            }

            if (current1 != null)
            {
                tail.Next = current1;
            }
            else
            {
                tail.Next = current2;
            }

            LinkedList mergedList = new LinkedList();
            mergedList.Head = dummy.Next;
            return mergedList;
        }

        public void RemoveDuplicates()
        {
            if (Head == null)
                return;

            Node current = Head;

            while (current != null && current.Next != null)
            {
                if (current.Value == current.Next.Value)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        public override string ToString()
        {
            Node current = Head;
            string result = "";
            while (current != null)
            {
                result += $"{current.Value} -> ";
                current = current.Next;
            }
            result += "null";
            return result;
        }
    }
}
