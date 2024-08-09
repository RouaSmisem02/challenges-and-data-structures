using System;
using Xunit;
using StackAndQueue.MinStack;

namespace TestProject
{
    public class MinStackTests
    {
        [Fact]
        public void TestPushAndGetMin()
        {
            MinStack stack = new MinStack();
            stack.Push(5);
            stack.Push(3);
            stack.Push(7);
            stack.Push(2);
            Assert.Equal(2, stack.GetMin());
        }

        [Fact]
        public void TestPopAndGetMin()
        {
            MinStack stack = new MinStack();
            stack.Push(5);
            stack.Push(3);
            stack.Push(7);
            stack.Push(2);
            stack.Pop();
            Assert.Equal(3, stack.GetMin());
        }

        [Fact]
        public void TestIsEmpty()
        {
            MinStack stack = new MinStack();
            Assert.True(stack.IsEmpty());
            stack.Push(1);
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void TestTop()
        {
            MinStack stack = new MinStack();
            stack.Push(10);
            stack.Push(20);
            Assert.Equal(20, stack.Top());
        }

        [Fact]
        public void TestPrintStack()
        {
            MinStack stack = new MinStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(5);
            stack.PrintStack();
        }
    }
}
