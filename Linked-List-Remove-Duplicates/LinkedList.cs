using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Remove_Duplicates
{
    public class LinkedList
    {
        public Node HeadNode { get; set; }

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (HeadNode == null)
            {
                HeadNode = newNode;
            }
            else
            {
                Node currentNode = HeadNode;
                while (currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.NextNode = newNode;
            }
        }

        public void DeleteDuplicates()
        {
            Node currentNode = HeadNode;
            while (currentNode != null)
            {
                Node runnerNode = currentNode;
                while (runnerNode.NextNode != null)
                {
                    if (runnerNode.NextNode.DataValue == currentNode.DataValue)
                    {
                        runnerNode.NextNode = runnerNode.NextNode.NextNode;
                    }
                    else
                    {
                        runnerNode = runnerNode.NextNode;
                    }
                }
                currentNode = currentNode.NextNode;
            }
        }

        public void PrintList()
        {
            Node currentNode = HeadNode;
            while (currentNode != null)
            {
                Console.Write(currentNode.DataValue + " -> ");
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine("Null");
        }
    }
}