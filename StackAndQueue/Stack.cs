using System;

namespace StackAndQueue
{
    public class Stack
    {
        private Node topNode;

        public Stack()
        {
            topNode = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.NextNode = topNode;
            topNode = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            int data = topNode.Data;
            topNode = topNode.NextNode;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return topNode.Data;
        }

        public bool IsEmpty()
        {
            return topNode == null;
        }
    }
}
