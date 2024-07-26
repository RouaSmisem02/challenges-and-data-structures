using System;

namespace StackAndQueue
{
    public class Node
    {
        public int Data { get; set; }
        public Node NextNode { get; set; }

        public Node(int data)
        {
            Data = data;
            NextNode = null;
        }
    }
}
