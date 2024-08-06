using System;
using Xunit;
using StackAndQueue.DeleteMiddleElement;

namespace TestProject
{
    public class StackWithDeleteMiddleTests
    {
        [Fact]
        public void TestDeleteMiddle_OddSizedStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            stack.DeleteMiddle();
            Assert.Equal("Stack: Top -> 5 -> 8 -> 14 -> 7", stack.ToString());
        }

        [Fact]
        public void TestDeleteMiddle_EvenSizedStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);
            stack.Push(2);

            stack.DeleteMiddle();
            Assert.Equal("Stack: Top -> 2 -> 5 -> 8 -> 14 -> 7", stack.ToString());
        }

        [Fact]
        public void TestDeleteMiddle_EmptyStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            Assert.Throws<InvalidOperationException>(() => stack.DeleteMiddle());
        }

        [Fact]
        public void TestDeleteMiddle_SingleElementStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.DeleteMiddle();
            Assert.Equal("Stack: Top -> ", stack.ToString());
        }
    }
}
