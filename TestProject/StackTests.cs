using System;
using Xunit;
using StackAndQueue;

namespace TestProject
{
    public class StackTests
    {
        [Fact]
        public void TestPush()
        {
            Stack stack = new Stack();
            stack.Push(10);
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void TestPop()
        {
            Stack stack = new Stack();
            stack.Push(10);
            int popped = stack.Pop();
            Assert.Equal(10, popped);
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void TestIsEmpty()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
            stack.Push(10);
            Assert.False(stack.IsEmpty());
        }
    }
}
