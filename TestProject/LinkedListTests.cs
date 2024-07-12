using System;
using System.IO;
using Xunit;
using LinkedList_1;

public class CustomLinkedListTests
{
    [Fact]
    public void TestRemoveNodeFromEnd()
    {
        CustomLinkedList list = new CustomLinkedList();
        list.Add(5);
        list.Add(10);
        list.Add(20);
        list.Remove(20);

        Assert.False(list.Includes(20));
    }

    [Fact]
    public void TestPrintList()
    {
        CustomLinkedList list = new CustomLinkedList();
        list.Add(5);
        list.Add(10);
        list.Add(20);

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            list.PrintList();
            var result = sw.ToString().Trim();
            Assert.Equal("Head -> 5 -> 10 -> 20 -> Null", result);
        }
    }
}
