using System;
using Xunit;
using StackAndQueue;

namespace TestProject
{
    public class QueueTests
    {
        [Fact]
        public void TestEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            Assert.False(queue.IsEmpty());
        }

        [Fact]
        public void TestDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            int dequeued = queue.Dequeue();
            Assert.Equal(10, dequeued);
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void TestIsEmpty()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
            queue.Enqueue(10);
            Assert.False(queue.IsEmpty());
        }
    }
}