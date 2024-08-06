using System;
using System.Collections.Generic;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle : Stack<int>
    {
        public void DeleteMiddle()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int middleIndex = (this.Count - 1) / 2;
            Stack<int> tempStack = new Stack<int>();

            for (int i = 0; i < middleIndex; i++)
            {
                tempStack.Push(this.Pop());
            }

            this.Pop();

            while (tempStack.Count > 0)
            {
                this.Push(tempStack.Pop());
            }
        }

        public override string ToString()
        {
            return "Stack: Top -> " + string.Join(" -> ", this.ToArray());
        }
    }
}
