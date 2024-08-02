using System;
using Xunit;

namespace ReverseStackUsingQueue
{
    public class StackWithReverseTests
    {
        [Fact]
        public void TestReverseMultipleElements()
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(4, stack.Pop());
            Assert.Equal(5, stack.Pop());
        }

        [Fact]
        public void TestReverseSingleElement()
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void TestReverseEmptyStack()
        {
            StackWithReverse stack = new StackWithReverse();

            stack.ReverseStack();

            Assert.Empty(stack);
        }
    }
}
