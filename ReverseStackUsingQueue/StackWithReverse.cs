using System;
using System.Collections.Generic;

namespace ReverseStackUsingQueue
{
    public class StackWithReverse : Stack<int>
    {
        public void ReverseStack()
        {
            if (this.Count <= 1) return;

            Queue<int> queue = new Queue<int>();

            while (this.Count > 0)
            {
                queue.Enqueue(this.Pop());
            }

            while (queue.Count > 0)
            {
                this.Push(queue.Dequeue());
            }
        }

        public override string ToString()
        {
            return $"Stack: Top -> {string.Join(" -> ", this.ToArray())}";
        }
    }
}
