using Xunit;
using LinkedListImplementation;

public class MergeSortedLinkedListsTests
{
    [Fact]
    public void Test_MergingWhenOneListIsEmpty()
    {
        // Arrange
        LinkedList list1 = new LinkedList();
        list1.Add(1);
        list1.Add(3);
        list1.Add(5);

        LinkedList list2 = new LinkedList();

        // Act
        LinkedList mergedList = list1.MergeSortedLists(list1, list2);

        // Assert
        Assert.Equal("1 -> 3 -> 5 -> null", mergedList.ToString());
    }

    [Fact]
    public void Test_MergingWhenBothListsAreEmpty()
    {
        // Arrange
        LinkedList list1 = new LinkedList();
        LinkedList list2 = new LinkedList();

        // Act
        LinkedList mergedList = list1.MergeSortedLists(list1, list2);

        // Assert
        Assert.Null(mergedList.Head);
    }

    [Fact]
    public void Test_MergingExampleLists()
    {
        // Arrange
        LinkedList list1 = new LinkedList();
        list1.Add(5);
        list1.Add(10);
        list1.Add(15);

        LinkedList list2 = new LinkedList();
        list2.Add(2);
        list2.Add(3);
        list2.Add(20);

        // Act
        LinkedList mergedList = list1.MergeSortedLists(list1, list2);

        // Assert
        Assert.Equal("2 -> 3 -> 5 -> 10 -> 15 -> 20 -> null", mergedList.ToString());
    }
}
