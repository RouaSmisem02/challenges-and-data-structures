using System;
using Xunit;
using Linked_List_Remove_Duplicates; // Use your custom namespace for the LinkedList class

namespace TestProject
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void Test_NoDuplicates()
        {
            LinkedList TestList = new LinkedList();
            TestList.Insert(1);
            TestList.Insert(2);
            TestList.Insert(3);
            TestList.DeleteDuplicates();
            Assert.Equal("1 -> 2 -> 3 -> Null", GetListString(TestList));
        }

        [Fact]
        public void Test_WithDuplicates()
        {
            LinkedList TestList = new LinkedList();
            TestList.Insert(1);
            TestList.Insert(2);
            TestList.Insert(2);
            TestList.Insert(3);
            TestList.Insert(3);
            TestList.DeleteDuplicates();
            Assert.Equal("1 -> 2 -> 3 -> Null", GetListString(TestList));
        }

        [Fact]
        public void Test_AllDuplicates()
        {
            LinkedList TestList = new LinkedList();
            TestList.Insert(7);
            TestList.Insert(7);
            TestList.Insert(7);
            TestList.DeleteDuplicates();
            Assert.Equal("7 -> Null", GetListString(TestList));
        }

        private string GetListString(LinkedList testList)
        {
            Node currentNode = testList.HeadNode;
            string result = string.Empty;
            while (currentNode != null)
            {
                result += currentNode.DataValue + " -> ";
                currentNode = currentNode.NextNode;
            }
            result += "Null";
            return result;
        }
    }
}
