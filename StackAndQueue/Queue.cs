using System;

namespace StackAndQueue
{
    public class Queue
    {
        private Node frontNode;
        private Node rearNode;

        public Queue()
        {
            frontNode = rearNode = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rearNode == null)
            {
                frontNode = rearNode = newNode;
                return;
            }
            rearNode.NextNode = newNode;
            rearNode = newNode;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            int data = frontNode.Data;
            frontNode = frontNode.NextNode;
            if (frontNode == null)
            {
                rearNode = null;
            }
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return frontNode.Data;
        }

        public bool IsEmpty()
        {
            return frontNode == null;
        }
    }
}
